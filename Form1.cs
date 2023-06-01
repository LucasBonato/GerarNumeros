using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
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
                ListaAnterior();
            }
            else if (Verificar())
            {
                switch (i)
                {
                    case 0:
                        NumeroPar();
                        break;
                    case 1:
                        NumeroImpar();
                        break;
                    case 2:
                        MultiploDe();
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
        private void NumeroPar()
        {
            LimparLista();

            if(numAPartir % 2 == 1) //Número inicial ímpar
            {
                numAPartir++;
                Loop(2);
            }
            else //Número inicial par 
            {    
                Loop(2);
            }
        }
        private void NumeroImpar()
        {
            LimparLista();

            if (numAPartir % 2 != 1) //Número inicial ímpar
            {
                numAPartir--;
                Loop(2);
            }
            else //Número inicial par 
            {
                Loop(2);
            }
        }
        private void MultiploDe()
        {
            LimparLista();

            if (MultiVerify())
            {
                MultiLoop(numMulti);
            }
            else
            {
                MensagemErro("campo");
            }
        }
        private void ListaAnterior()
        {
            LimparLista();
            Adicionar();
        }
        private void Loop(double soma) // O Array recebe os valores
        {
            int i = 0;
            valor[i] = numAPartir;
            for (int c = i + 1; c < numQuantidade; c++)
            {
                numAPartir += soma;
                valor[c] = numAPartir;
            }
            Adicionar();
        }
        private void MultiLoop(double m)
        {
            if(numAPartir % m == 0)
            {
                Loop(m);
            } 
            else
            {
                while(numAPartir % m != 0)
                {
                    numAPartir++;
                }
                Loop(m);
            }
        }
        private void Adicionar() // Adiciona os itens do Array para a lista
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
            Array.Clear(arr, 0, arr.Length); // Limpando o Array

            void AdicionarItem(int index)
            {
                arr[index] = auxiliar;
                listBox.Items.Add(arr[index]);
            }
        }
        private void RadioBtn(out double radio) // Verificar qual radio está clicado
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
        private void comBoxChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxChoise.SelectedIndex == 2)
            {
                MultiOfChangeView(true);
            } 
            else
            {
                MultiOfChangeView(false);
            }
        }
        private void LimparLista() { listBox.Items.Clear(); } //Limpa a lista de itens
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