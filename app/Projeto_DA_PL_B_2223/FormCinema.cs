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
    public partial class FormCinema : Form
    {
        public FormCinema()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void buttonGuardarCinema_Click(object sender, EventArgs e)
        {
            atualizarDadosLabel(); // ATUALIZA OS DADOS DAS LABELS
        }
        private void atualizarDadosLabel()
        {   // RECEBE AS VARIAVEIS DAS TEXTBOX
            string nome = textBoxNomeCinema.Text;
            string morada = textBoxMoradaCinema.Text;
            string email = textBoxEmailCinema.Text;
            // INSTANCIAR 
            Cinema cinema = new Cinema(nome, morada, email);
            // ENVIAR PARA OS LABELS
            labelNomeCinema.Text = cinema.NomeCinema;
            labelMoradaCinema.Text = cinema.MoradaCinema;
            labelEmailCinema.Text = cinema.EmailCinema;
            //FormPrincipal.labelNomeCinema.Text = cinema.NomeCinema;// ATUALIZAR LABEL DO FORM PRINCIPAL


        }
    }
}
