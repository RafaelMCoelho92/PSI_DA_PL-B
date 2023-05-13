using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void buttonAdicionarSala_Click(object sender, EventArgs e)
        {
            string nomeSala = textBoxNomeSala.Text;
                if (nomeSala.Length == 0 )
                {
                    MessageBox.Show("O nome da sala não pode ser vazio");
                }
            Sala sala = new Sala(nomeSala);
            listBoxSalas.Items.Add(sala);

        }

        private void buttonEditarFilasColunas_Click(object sender, EventArgs e)
        {
            string fila = textBoxFilas.Text;
            string coluna = textBoxColunas.Text;

            double valorFila = 0;
            double valorColuna = 0;

            try
            {
                valorFila = double.Parse(fila);
                valorColuna = double.Parse(coluna);

                if (valorFila <= 0 || valorColuna <= 0) 
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser superior a 0 (zero)");
                    return;
                }
                if(valorFila > 20 || valorColuna > 20)
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser inferior a 20");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valor Invalido");
            }
 

        }
    }
}
