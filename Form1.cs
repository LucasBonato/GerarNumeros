using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int[] valor = new int[1000];
        int numMulti, numAPartir, numQuantidade;
        
        public Form1()
        {
            InitializeComponent();
            comBoxChoise.SelectedIndex = 0;
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            int i = comBoxChoise.SelectedIndex;
            if (Verificar())
            {
                switch (i)
                {
                    case -1:
                        MensagemErro("lista"); 
                        break;
                    case 0:
                        NumeroPar();
                        break;
                    case 1:
                        NumeroImpar();
                        break;
                    case 2:
                        MultiploDe();
                        break;
                    case 3:
                        ListaAnterior();
                        break;
                    default:
                        Verificar();
                        break;
                }
            }
            else
            {
                MensagemErro("campos");
            }
        }

        public void MensagemErro(string opcao)
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
                    MessageBox.Show("Algo não está funcionando corretamente!", "ERROR", MessageBoxButtons.OK);
                    break;
            }
        }

        private bool Verificar()
        {
            string quantidade = txtBoxQuantidade.Text, multiploDe = txtBoxMultiOf.Text, aPartir = txtBoxPartirNum.Text;
            bool resposta;

            if ((quantidade.Length < 0 || multiploDe.Length < 0 || aPartir.Length < 0))
            {
                resposta = false;
            } 
            else if (!(int.TryParse(quantidade, out numQuantidade) && int.TryParse(multiploDe, out numMulti) && int.TryParse(aPartir, out numAPartir)))
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
            Limpar();

            if(numAPartir % 2 == 1) //Número inicial ímpar
            {
                numAPartir++;
                Loop();
            }
            else //Número inicial par 
            {    
                Loop();
            }
        }
        private void NumeroImpar()
        {
            Limpar();

            if (numAPartir % 2 != 1) //Número inicial ímpar
            {
                numAPartir--;
                Loop();
            }
            else //Número inicial par 
            {
                Loop();
            }
        }
        private void MultiploDe()
        {
            label1.Text = "Multiplo";
        }
        private void ListaAnterior()
        {
            label1.Text = "Anterior";
        }
        private void Limpar() { listBox.Items.Clear(); }
        private void Loop()
        {
            int i = 0;
            valor[i] = numAPartir;
            for (int c = i + 1; c < numQuantidade; c++)
            {
                valor[c] = numAPartir + 2;
                numAPartir += 2;
            }
            Adicionar();
        }
        private void Adicionar()
        {
            for (int i = 0; i < numQuantidade; i++)
            {
                listBox.Items.Add(valor[i]);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
