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
        private FormPrincipal formPrincipal;

        public FormCinema()
        {
            InitializeComponent();
        }

        public FormCinema(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        // GUARDA OS DADOS DO CINEMA
        private void buttonGuardarCinema_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var cinema = new Cinema (textBoxNomeCinema.Text , textBoxMoradaCinema.Text, textBoxEmailCinema.Text);
                db.Cinemas.Add(cinema);
                db.SaveChanges();

                var listCinemas = db.Cinemas.ToList();
                labelNomeCinema.Text = listCinemas.LastOrDefault()?.NomeCinema;
                formPrincipal.setNomeCinema(cinema.NomeCinema);
            }

            string nome = textBoxNomeCinema.Text;
            string morada = textBoxMoradaCinema.Text;
            string email = textBoxEmailCinema.Text;
            validarDadosInseridos(); //metodo para validar os dados inseridos
            if (nome.Length > 0 && morada.Length > 0 && email.Length > 0)
            {
                atualizarDadosLabel(); // METODO PARA ATUALIZAR OS DADOS DAS LABELS

            }


        }// ATUALIZA AS LABELS DA LISTBOX
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
            //Instanciar?
            //FormPrincipal.labelNomeCinema.Text = cinema.NomeCinema;// ATUALIZAR LABEL DO FORM PRINCIPAL
        }
        //VALIDA OS DADOS INSERIDOS 
        public void validarDadosInseridos()
        {
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            string nome = textBoxNomeCinema.Text;
            if (nome.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string morada = textBoxMoradaCinema.Text;
            if (morada.Length == 0)
            {
                MessageBox.Show("A morada não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string email = textBoxEmailCinema.Text;
            if (email.Length == 0)
            {
                MessageBox.Show("O email não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
