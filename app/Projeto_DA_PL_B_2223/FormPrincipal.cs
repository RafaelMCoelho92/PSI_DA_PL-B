using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // foi para por data e hora



namespace Projeto_DA_PL_B_2223
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            // FORM CENTRADO COM ECRA
            this.CenterToScreen();
        }

        //FUNCAO QUE EXECUTA AO ABRIR O FORM
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // PRA VER NA BASE DE DADOS
            ApplicationContext context = new ApplicationContext();

            while (context.Cinemas.Count() == 0 ) // ENQUANTO A CONTAGEM DE CINEMAS FOR IGUAL A 0, VAI ABRIR O FORM DE CINEMA
            {
                FormCinema formCinema = new FormCinema(); // INSTANCIA DO FORM CINEMA
                formCinema.ShowDialog();
            }
            while(toolStripStatusLabelNomeFuncionarioLogado.Text == "FAÇA LOGIN") // vai mostrar o form de funcionarios enquanto n escolher um funcionario para estar logado
            {
                Form formFuncionarios = new FormFuncionarios();
                formFuncionarios.ShowDialog();
            }
        }

        // MOSTRA A DATA E A HORA 
        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)
        }

        //CHAMA A TAB DOS CLIENTES
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Form formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        // CHAMA A TAB DAS SESSOES DO DIA CLICANDO NA LABEL DO TITULO DO CINEMA
        private void labelNomeCinema_Click(object sender, EventArgs e)
        {
            Form formSessoesDia = new FormSessoesDoDia();
            formSessoesDia.ShowDialog();
        }

        // CHAMA A TAB DOS FUNCIONARIOS
        private void buttonaAlterarFuncionario_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormLogin().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DOS CINEMAS
        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCinema = new FormCinema();
            formCinema.ShowDialog();
        }

        // CHAMA A TAB DAS SALAS
        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSala = new FormSala();
            formSala.ShowDialog();
        }

        // CHAMA A TAB DOS FUNCIONAROS
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        // CHAMA A TAB DAS SESSOES
        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSessoes = new FormSessoes();
            formSessoes.ShowDialog();
        }

        // CHAMA A TAB DOS FILMES
        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formFilmes = new FormFilmes();
            formFilmes.ShowDialog();
        }

        // CHAMA A TAB DAS SESSOES DO DIA
        private void sessãoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSessoesDia = new FormSessoesDoDia();
            formSessoesDia.ShowDialog();
        }

        // MÉTODO PARA ATUALIZAR A LABEL COM O TITULO DO CINEMA
        public void setNomeCinema(string nomeCinema)
        {
            labelNomeCinema.Text = nomeCinema;
        }

        // MÉTODO PARA ATUALIZAR A LABEL COM O NOME DO FUNCIONARIO LOGADO
        public void setNomeFuncionario(int Id)
        {
            var db = new ApplicationContext();
            var funcionario = db.Pessoas.Find(Id); // procura o funcionario pelo id recebido
            toolStripStatusLabelNomeFuncionarioLogado.Text = funcionario.NomePessoa; // po o nome na label
        }

        private void toolStripStatusLabelNomeFuncionarioLogado_Click(object sender, EventArgs e)
        {
            Form formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }


    }
}
