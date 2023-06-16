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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // INVISIVEL OS OUTROS BOTOES ENQUANTO N FIZER LOG IN
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if ( textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                //DEPOIS DE LOGIN FEITO METER O NOME DO USER NO toolStripStatusLabelNomeFuncionarioLogado
                // BOTOES VISIVEIS
                // SE CINEMA == NULL -> FormCinema
                //Senao tela inicial
            }
            else
            {
                MessageBox.Show("Username e/ou password incorreto(s)! Tente novamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}