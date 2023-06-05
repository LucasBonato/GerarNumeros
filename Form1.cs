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
        double[] valor = new double[1000];
        double numMulti, numAPartir, numQuantidade, numLinha;
        public Form1()
        {
            InitializeComponent();
            Change("multi", false);
            comBoxChoise.SelectedIndex = 0;
        }
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int i = comBoxChoise.SelectedIndex;
            RadioBtn(out numLinha);
            if (i == 3)
            {
                Adicionar();
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
            }

            void NumeroPar()
            {
                if (numAPartir % 2 == 1) //Número inicial ímpar
                {
                    numAPartir++;
                    LoopPar();
                }
                else //Número inicial par 
                {
                    LoopPar();
                }
            }
            void NumeroImpar()
            {
                if (numAPartir % 2 == 0) //Número inicial par
                {
                    numAPartir++;
                    LoopImpar();
                }
                else //Número inicial ímpar
                {
                    LoopImpar();
                }
            }
            void MultiploDe()
            {
                if (MultiVerify())
                {
                    LoopMultiplo(numMulti);
                }
            }
            Adicionar();
        }
        private void LoopPar()
        {
            int i = 0;
            valor[i] = numAPartir;
            for (int c = i + 1; c < numQuantidade; c++)
            {
                numAPartir += 2;
                valor[c] = numAPartir;
            }
        }
        private void LoopImpar()
        {
            int i = 0;
            valor[i] = numAPartir;
            i++;
            while (i < numQuantidade)
            {
                numAPartir += 2;
                valor[i] = numAPartir;
                i++;
            }
        }
        private void LoopMultiplo(double m)
        {
            if (numAPartir % m == 0)
            {
                MultiLoop(m);
            }
            else
            {
                while (numAPartir % m != 0)
                {
                    numAPartir++;
                }
                MultiLoop(m);
            }

            void MultiLoop(double soma)
            {
                int i = 0;
                valor[i] = numAPartir;
                do
                {
                    i++;
                    numAPartir += soma;
                    valor[i] = numAPartir;
                } while (i < numQuantidade);
            }
        }
        private void Adicionar()
        {
            // Adiciona os números para uma string auxiliar para ser mostrado na ListBox.
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
            // Verfica qual das bolinhas foi selecionada.
            if (radioBtnTen.Checked == true)
            {
                radio = 10;
            }
            else if (radioBtnFive.Checked == true)
            {
                radio = 5;
            }
            else
            {
                radio = 1;
            }
        }
        private void Change(string qual, bool troca = true)
        {
            switch (qual)
            {
                case "multi":
                    MultiOfChangeView(troca);
                    break;
                case "all":
                    AllChangeView(troca);
                    MultiOfChangeView(troca);
                    break;
                case "alternado":
                    AllChangeView(true);
                    MultiOfChangeView(false);
                    break;
            }

            void MultiOfChangeView(bool change)
            {
                // mostra ou esconde a caixa 'Multiplo De'.
                txtBoxMultiOf.Visible = change;
                lblMultiOf.Visible = change;
            }

            void AllChangeView(bool change)
            {
                // Mostra ou esconde as caixas que se colocar os números.
                txtBoxPartirNum.Visible = change;
                lblAPartir.Visible = change;

                txtBoxQuantidade.Visible = change;
                lblQntd.Visible = change;
            }
        }
        private bool Verificar()
        {
            string quantidade = txtBoxQuantidade.Text, aPartir = txtBoxPartirNum.Text;
            bool resposta;

            if ((quantidade.Length < 0 || aPartir.Length < 0))
            {
                MensagemErro("campos");
                resposta = false;
            }
            else if (!(double.TryParse(quantidade, out numQuantidade) && double.TryParse(aPartir, out numAPartir)))
            {
                MensagemErro("numero");
                resposta = false;
            }
            else if (numQuantidade > 1000)
            {
                MensagemErro("alto");
                resposta = false;
            }
            else if (numQuantidade < 0)
            {
                MensagemErro("baixo");
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
                MensagemErro("campo");
                response = false;
            }
            else if (!double.TryParse(multiploDe, out numMulti))
            {
                MensagemErro("numero");
                response = false;
            }
            else if (numMulti == 0)
            {
                MensagemErro("multiZero");
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
                case "alto":
                    MessageBox.Show("O limite da quantidade foi excedido por favor escolha um número menor que 1000!", "Limite Atingido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "baixo":
                    MessageBox.Show("A quantidade não pode ser menor do que 0, escolha um número maior!", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "multiZero":
                    MessageBox.Show("Selecione algum número diferente de zero no 'Multiplo de'!", "Ação Impossível", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void comBoxChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Método para esconder ou mostrar quando um item do comboBox é selecionado.
            if (comBoxChoise.SelectedIndex == 2)
            {
                Change("all");
            }
            else if (comBoxChoise.SelectedIndex == 3)
            {
                Change("all", false);
            }
            else
            {
                Change("alternado");
            }
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