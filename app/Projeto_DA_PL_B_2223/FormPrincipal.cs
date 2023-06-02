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
        Form formCinema; // nao fazer instancia mas sim mandar para o o construtor
        Form formFuncionarios;
        Form formClientes;
        Form formSessoesDia;
        Form formSala;
        Form formSessoes;
        Form formFilmes;


        public FormPrincipal()
        {
            InitializeComponent();
            // FORM CENTRADO COM ECRA
            this.CenterToScreen();
            formFuncionarios = new FormFuncionarios(this);
            formClientes = new FormClientes(this);
            formSessoesDia = new FormSessoesDoDia(this);
            formSala = new FormSala(this);
            formSessoes = new FormSessoes(this);
            formFilmes = new FormFilmes(this);
            formCinema = new FormCinema(this);
            dateTimePickerSessoesFormPrinc.MinDate = DateTime.Now; // seleciona data de hoje pra frente


        }

        //FUNCAO QUE EXECUTA AO ABRIR O FORM
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // PRA VER NA BASE DE DADOS
            ApplicationContext context = new ApplicationContext();

            while (context.Cinemas.Count() == 0 ) // ENQUANTO A CONTAGEM DE CINEMAS FOR IGUAL A 0, VAI ABRIR O FORM DE CINEMA
            {
                formCinema.ShowDialog();
            }
            while(toolStripStatusLabelNomeFuncionarioLogado.Text == "FAÇA LOGIN") // vai mostrar o form de funcionarios enquanto n escolher um funcionario para estar logado
            {
                formFuncionarios.ShowDialog();
            }
            atualizarDadosAoEntrar();
           // dateTimePicker_formPrincipal();
        }
        private void atualizarDadosAoEntrar()
        {
            listBox_mostrar_sessoes_dia.Items.Clear();
                using (var bd = new ApplicationContext())
                {
                    var sessoes = bd.Sessoes.ToList();
                    foreach (var sessao in sessoes) //correr os clientes para os adicionar à listBox 
                    {
                        listBox_mostrar_sessoes_dia.Items.Add(sessao);
                    }
                }
        }

        private void dateTimePickerSessoesFormPrinc_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_formPrincipal(); // estou a chamar mas em tentativa erro 
        }


        // MOSTRA A DATA E A HORA 
        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)
        }

        // CHAMA A TAB DAS SESSOES DO DIA CLICANDO NA LABEL DO TITULO DO CINEMA
        private void labelNomeCinema_Click(object sender, EventArgs e)
        {
            formSessoesDia.ShowDialog(this);
        }

        // CHAMA A TAB DOS FUNCIONARIOS
        /*private void buttonaAlterarFuncionario_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormLogin().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }*/

        // CHAMA A TAB DOS CINEMAS
        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCinema.ShowDialog();
        }

        // CHAMA A TAB DAS SALAS
        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSala.ShowDialog();
        }

        // CHAMA A TAB DOS FUNCIONAROS
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionarios.ShowDialog();
        }

        // CHAMA A TAB DAS SESSOES
        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSessoes.ShowDialog();
        }

        // CHAMA A TAB DOS FILMES
        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFilmes.ShowDialog();
        }

        // CHAMA A TAB DAS SESSOES DO DIA
        private void sessãoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            formFuncionarios.ShowDialog();
        }
        //CHAMA O FORM DOS CLIENTES
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formClientes.ShowDialog();
        }

        private void dateTimePicker_formPrincipal()
        {

            using (var bd = new ApplicationContext())
            {
                string dataSelecionada = dateTimePickerSessoesFormPrinc.Value.ToString("dd/MM/yyyy");
                var sessoes = bd.Sessoes.Where(sessao => sessao.Data == dataSelecionada).ToList(); // esta linha fui procurar ao chatgpt, não estou a ver outra forma

                listBox_mostrar_sessoes_dia.Items.Clear();
                    foreach (var sessao in sessoes)
                    {
                        listBox_mostrar_sessoes_dia.Items.Add(sessao);
                    }
                
            }
        }
    }
}
