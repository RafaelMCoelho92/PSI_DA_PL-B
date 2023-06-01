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
            this.CenterToScreen(); // centra o form no ecrã
            atualizarDadosAoEntrar();

        }
        private void atualizarDadosAoEntrar()
        {
            using (ApplicationContext db = new ApplicationContext()) // using para liberar recursos no fim, boas praticas
            {
                var cinema = db.Cinemas.FirstOrDefault(); //podemos usar tbm SingleOrDefaul,First(se n tiver vai abrir uma exceção)
                if (cinema != null) // Caso na bd não tenha cinema
                {
                    textBoxNomeCinema.Text = cinema.NomeCinema;// mete no textbox para facilitar a alteração
                    textBoxMoradaCinema.Text = cinema.MoradaCinema;
                    textBoxEmailCinema.Text = cinema.EmailCinema;

                    labelNomeCinema.Text = cinema.NomeCinema; // mostra no label os dados
                    labelMoradaCinema.Text = cinema.MoradaCinema;
                    labelEmailCinema.Text = cinema.EmailCinema;
                }
            }
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
            // a funcao abaixo retorna false se n cumprir qualquer um dos parametros, retorna true se cumprir a todos
            if(!validarDadosInseridos())// se for FALSO sai, se for true continua
            {
                return;
            }
            // Verificar se o cinema já existe na base de dados
            //using é para liberar os recursos no fim não é nescessario mas é boa pratica 
            using (var db = new ApplicationContext())
            {
                var existeCinema = db.Cinemas.FirstOrDefault();
                if (existeCinema != null)
                {
                    // O cinema já existe, atualizar os dados
                    existeCinema.NomeCinema = textBoxNomeCinema.Text;
                    existeCinema.MoradaCinema = textBoxMoradaCinema.Text;
                    existeCinema.EmailCinema = textBoxEmailCinema.Text;
                }
                else
                {
                    // O cinema não existe, criar um novo cinema
                    var cinema = new Cinema(textBoxNomeCinema.Text, textBoxMoradaCinema.Text, textBoxEmailCinema.Text);
                    db.Cinemas.Add(cinema);
                }

                db.SaveChanges();
            }
            // Atualizar os dados das labels
            atualizarDadosLabel();
        }
        // ATUALIZA AS LABELS DA LISTBOX
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
        }

        //VALIDA OS DADOS INSERIDOS 
        public bool validarDadosInseridos()
        {

                // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS

            //Retorna falso para quando nao esta a cumprir os parametros
            //retorna true quando cumpre
                string nome = textBoxNomeCinema.Text;
                if (nome.Length == 0)
                {
                    MessageBox.Show("O nome não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                string morada = textBoxMoradaCinema.Text;
                if (morada.Length == 0)
                {
                    MessageBox.Show("A morada não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                string email = textBoxEmailCinema.Text;
                if (email.Length == 0)
                {
                    MessageBox.Show("O email não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!email.Contains("@"))
                {
                    MessageBox.Show("O email tem de conter formato de email válido - (@) ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true ;
                }

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            if (context.Cinemas.Any())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Registe primeiro um cinema", "Aviso", MessageBoxButtons.OK , MessageBoxIcon.Warning );
            }
        }

        private void FormCinema_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }
    }
}
