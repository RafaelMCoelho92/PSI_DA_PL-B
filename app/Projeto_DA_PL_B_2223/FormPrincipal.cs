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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            FormCinema form = new FormCinema();
            form.ShowDialog();
        }

        private void buttonFilmes_Click(object sender, EventArgs e)
        {
            FormFilmes form = new FormFilmes();
            form.ShowDialog();
        }

        private void buttonSessoes_Click(object sender, EventArgs e)
        {
            FormSessoes form = new FormSessoes();
            form.ShowDialog();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            form.ShowDialog();
        }
    }
}
