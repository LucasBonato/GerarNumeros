using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarNumero
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            MultiOfChangeView(false);
            comBoxChoise.SelectedIndex = 0;
        }

        double[] valor = new double[1000];
        double numMulti, numAPartir, numQuantidade, numLinha;

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int i = comBoxChoise.SelectedIndex;
            RadioBtn(out numLinha);
            if (i == 3)
            {
                NumbersLoops("ListaAnte");
            }
            else if (Verificar())
            {
                switch (i)
                {
                    case 0:
                        NumbersLoops("Par");
                        break;
                    case 1:
                        NumbersLoops("Impar");
                        break;
                    case 2:
                        NumbersLoops("Multiplo");
                        break;
                    default:
                        MensagemErro("lista");
                        break;
                }
            }
            else
            {
                MensagemErro("campos");
            }
        }
        private void comBoxChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxChoise.SelectedIndex == 2)
            {
                AllChangeView(true);
                MultiOfChangeView(true);
            }
            else if (comBoxChoise.SelectedIndex == 3)
            {
                AllChangeView(false);
                MultiOfChangeView(false);
            }
            else
            {
                AllChangeView(true);
                MultiOfChangeView(false);
            }
        }
        private void NumbersLoops(string tipoDoLoop)
        {
            LimparLista();

            switch (tipoDoLoop)
            {
                case "Par":
                    NumeroPar();
                    break;
                case "Impar":
                    NumeroImpar();
                    break;
                case "Multiplo":
                    MultiploDe();
                    break;
                case "ListaAnte":
                    break;
            }

            void NumeroPar()
            {
                if (numAPartir % 2 == 1) //Número inicial ímpar
                {
                    numAPartir++;
                    LoopPar(2);
                }
                else //Número inicial par 
                {
                    LoopPar(2);
                }
            }
            void NumeroImpar()
            {
                if (numAPartir % 2 != 1) //Número inicial ímpar
                {
                    numAPartir--;
                    LoopImpar(2);
                }
                else //Número inicial par 
                {
                    LoopImpar(2);
                }
            }
            void MultiploDe()
            {
                if (MultiVerify())
                {
                    MultiLoop(numMulti);
                }
                else
                {
                    MensagemErro("campo");
                }
            }
            Adicionar();
        }
        private void LoopPar(double soma)
        {
            int i = 0;
            valor[i] = numAPartir;
            int c = i + 1;
            while(c < numQuantidade)
            {
                numAPartir += soma;
                valor[c] = numAPartir;
                c++;
            }
        }
        private void LoopImpar(double soma)
        {
            int i = 0;
            valor[i] = numAPartir;
            do
            {
                numAPartir += soma;
                valor[i] = numAPartir;
                i++;
            } while (i < numQuantidade);
        }
        private void LoopMultiplo(double soma)
        {
            int i = 0;
            valor[i] = numAPartir;
            for (int c = i + 1; c < numQuantidade; c++)
            {
                numAPartir += soma;
                valor[c] = numAPartir;
            }
        }
        private void MultiLoop(double m)
        {
            if(numAPartir % m == 0)
            {
                LoopMultiplo(m);
            } 
            else
            {
                while(numAPartir % m != 0)
                {
                    numAPartir++;
                }
                LoopMultiplo(m);
            }
        }
        private void Adicionar()
        {
            string[] arr = new string[1000];
            string auxiliar = "";
            int j = 0;

            for (int i = 0; i < numQuantidade; i++)
            {
                if (i % numLinha == 0 && i != 0) // Próxima linha
                {
                    AdicionarItem(j);
                    j++;
                    auxiliar = "";
                }
                auxiliar += $"{valor[i]}\t";
            }
            AdicionarItem(j);

            void AdicionarItem(int index)
            {
                Array.Clear(arr, 0, arr.Length); // Limpando o Array
                arr[index] = auxiliar;
                listBox.Items.Add(arr[index]);
            }
        }
        private void RadioBtn(out double radio)
        {
            if(radioBtnOne.Checked == true) 
            { 
                radio = 1; 
            }
            else if (radioBtnFive.Checked == true) 
            { 
                radio = 5; 
            }
            else 
            { 
                radio = 10; 
            }
        }
        private void MultiOfChangeView(bool troca)
        {
            txtBoxMultiOf.Visible = troca;
            lblMultiOf.Visible = troca;
        }
        private void AllChangeView(bool troca)
        {
            txtBoxPartirNum.Visible = troca;
            lblAPartir.Visible = troca;

            txtBoxQuantidade.Visible = troca;
            lblQntd.Visible = troca;
        }
        private bool Verificar()
        {
            string quantidade = txtBoxQuantidade.Text, aPartir = txtBoxPartirNum.Text;
            bool resposta;

            if ((quantidade.Length < 0 || aPartir.Length < 0))
            {
                resposta = false;
            }
            else if (!(double.TryParse(quantidade, out numQuantidade) && double.TryParse(aPartir, out numAPartir)))
            {
                resposta = false;
            }
            else
            {
                resposta = true;
            }
            return resposta;
        }
        private bool MultiVerify()
        {
            bool response;
            string multiploDe = txtBoxMultiOf.Text;
            if (multiploDe.Length < 0)
            {
                response = false;
            } 
            else if (!double.TryParse(multiploDe, out numMulti))
            {
                response = false;
            }
            else
            {
                response = true;
            }

            return response;
        }
        private void MensagemErro(string opcao)
        {
            switch (opcao)
            {
                case "lista":
                    MessageBox.Show("Por favor, selecione alguma das opções da lista!", "OPÇÃO INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "campos":
                    MessageBox.Show("Por favor, preencha todos os campos antes de gerar a lista!", "Falta de informações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "numero":
                    MessageBox.Show("Por favor, só preencha os campos com números!", "Número", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Algo não está funcionando corretamente, verifique novamente e rode o programa!", "ERROR", MessageBoxButtons.OK);
                    break;
            }
        }
        private void LimparLista()
        { 
            listBox.Items.Clear(); 
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparLista();
            txtBoxMultiOf.Text = "";
            txtBoxPartirNum.Text = "";
            txtBoxQuantidade.Text = "";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}