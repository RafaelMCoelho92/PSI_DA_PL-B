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
    public partial class FormAtendimento : Form
    {
        private FormPrincipal formPrincipal;

        public FormAtendimento()
        {
            InitializeComponent();
            this.CenterToScreen();


        }

        public FormAtendimento(FormPrincipal formPrincipal) : this()
        {
            this.formPrincipal = formPrincipal;
            
        }


        
        public int getFilas(int Id)
        {
            var db = new ApplicationContext();
            var sessao = db.Sessoes.Find(Id); // procura a sessao pelo id recebido
            int idsala  = sessao.idSala ;  // ve qual o id da sala
            var filascolunas = db.Salas.Find(idsala); // vai buscar os dados da sala
            int filas = int.Parse(filascolunas.Fila); // faz o parse pra int da string com o valor das filas
            return filas;
        }
        public int getColunas(int Id)
        {
            var db = new ApplicationContext();
            var sessao = db.Sessoes.Find(Id); // procura a sessao pelo id recebido
            int idsala = sessao.idSala; // ve qual o id da sala
            var filascolunas = db.Salas.Find(idsala); // vai buscar os dados da sala
            int colunas = int.Parse(filascolunas.Coluna);// faz o parse pra int da string com valor das colunas
            return colunas;
        }
        public void setConfigSala(int id)
        {
            int filas = getFilas(id);
            int colunas = getColunas(id);
            tableLayoutPanelEscolherLugar.SuspendLayout();

            tableLayoutPanelEscolherLugar.Controls.Clear();
            tableLayoutPanelEscolherLugar.RowCount = filas;
            tableLayoutPanelEscolherLugar.ColumnCount = colunas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Button button = new LugarButton(i, j);
                    button.Size = new Size(50, 25);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    button.BackColor =  Color.Green;
                    button.ForeColor = Color.Black;
                    //button.Image = Properties.Resources.chair5381;
                    button.Click += LugarClicked;
                    tableLayoutPanelEscolherLugar.Controls.Add(button, j, i);
                }
            }
            tableLayoutPanelEscolherLugar.ResumeLayout();
        }
        private void LugarClicked(Object sender, EventArgs e)
        {
            LugarButton button = (LugarButton)sender;
            MessageBox.Show("Fila: " + button.X + " Coluna: " + button.Y + " Selecionada.");
        }

        private void radioButton_cliente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
