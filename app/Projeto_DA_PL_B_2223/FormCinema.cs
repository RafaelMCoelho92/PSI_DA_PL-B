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
            validarDadosInseridos(); //metodo para validar os dados inseridos
            atualizarDadosLabel(); // METODO PARA ATUALIZAR OS DADOS DAS LABELS
        }
        public void atualizarDadosLabel()
        {
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
        public void validarDadosInseridos()
        {
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            string nome = textBoxNomeCinema.Text;
            if (nome.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio");
                return;
            }
            string morada = textBoxMoradaCinema.Text;
            if (morada.Length == 0)
            {
                MessageBox.Show("A morada não pode ser vazio");
                return;
            }
            string email = textBoxEmailCinema.Text;
            if (email.Length == 0)
            {
                MessageBox.Show("O email não pode ser vazio");
                return;
            }
        }
    }
}
