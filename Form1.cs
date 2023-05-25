using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarNumero
{
    public partial class Form1 : Form
    {
        int[] valor = new int[100];
        float numMulti, numAPartir, numQuantidade;
        
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
            else if (!(float.TryParse(quantidade, out numQuantidade) && float.TryParse(multiploDe, out numMulti) && float.TryParse(aPartir, out numAPartir)))
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
            int i = (int)numAPartir;
            for (i = 0; i < numQuantidade; i++)
            {
                string teste;
                valor[i] = i * 2;
                for (int j = 10; j > 0; j--)
                {
                    teste += + $"{valor[i]} ";
                }
            }

            //numQuantidade;
            //numMulti;
            //numAPartir;
        }
        private void NumeroImpar()
        {
            label1.Text = "Impar";
        }
        private void MultiploDe()
        {
            label1.Text = "Multiplo";
        }
        private void ListaAnterior()
        {
            label1.Text = "Anterior";
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
