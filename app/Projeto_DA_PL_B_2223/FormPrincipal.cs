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
using System.Drawing.Text;

namespace Projeto_DA_PL_B_2223
{

    public partial class FormPrincipal : Form
    {
        Form formCinema; // nao fazer instancia mas sim mandar para o o construtor
        Form formFuncionarios;
        Form formClientes;
        Form formSala;
        Form formSessoes;
        Form formFilmes;
        Form formEstadoBilhete;
        //Form formCategorias;
       // Form formAtendimento;

        private FormAtendimento formAtendimento;

        public FormPrincipal()
        {
            InitializeComponent();
            // FORM CENTRADO COM ECRA
            this.CenterToScreen();
            formFuncionarios = new FormFuncionarios(this);
            formClientes = new FormClientes(this);
            formSala = new FormSala(this);
            formSessoes = new FormSessoes(this);
            formFilmes = new FormFilmes(this);
            formCinema = new FormCinema(this);
            formAtendimento = new FormAtendimento(this);
            formEstadoBilhete = new FormEstadoBilhete(this);
            //formCategorias = new FormCategorias(this);
            dateTimePickerSessoesFormPrinc.MinDate = DateTime.Now; // seleciona data de hoje pra frente
            setNomeCinema(1);
        }
        public FormPrincipal(FormAtendimento formAtendimento) : this() // recebemos no construtor deste form o form principal e podemos utilizar os metodos do principal
        {
            this.formAtendimento = formAtendimento;
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
                    if (sessao.Data == dateTimePickerSessoesFormPrinc.Value.ToString("dd/MM/yyyy"))
                    {
                        listBox_mostrar_sessoes_dia.Items.Add(sessao);
                    }
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

        // MÉTODO PARA ATUALIZAR A LABEL COM O TITULO DO CINEMA
        public void setNomeCinema(int Id)
        {
            var db = new ApplicationContext();
            var cinema = db.Cinemas.Find(Id); // procura o cinema pelo id recebido
            if(cinema == null)
            {
                return;
            }
            else
            {
            toolStripStatusLabelNomeCinema.Text = cinema.NomeCinema; // po o nome na label
            labelNomeCinema.Text = cinema.NomeCinema;
            }
            
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
        //CHAMA O FORM DOS BILHETES
        private void bilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEstadoBilhete.ShowDialog();
        }
        //CHAMA O FORM DAS CATEGORIAS
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formCategorias.ShowDialog();
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

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            atualizarDadosAoEntrar();
        }
        private int getIdFuncionario()
        {
            string nomeFuncionario = toolStripStatusLabelNomeFuncionarioLogado.Text;
            var db = new ApplicationContext();
            var funcionario = db.Pessoas.OfType<Funcionario>().FirstOrDefault(f => f.NomePessoa == nomeFuncionario );
            int idFuncionario = funcionario.Id;
            return idFuncionario;
        }

        private void listBox_mostrar_sessoes_dia_DoubleClick(object sender, EventArgs e)
        {
            //verificar que foi selecionado algo
            //caso tenha sido fazer o set das cadeiras da sala no form atendimento
            int escolherSessao = listBox_mostrar_sessoes_dia.SelectedIndex;
            if (escolherSessao == -1)
            {
                // se n tiver sessão selecionada mensagem de erro
                MessageBox.Show("Selecione uma Sessão", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//

            // buscar a sessao selecionada
            if (listBox_mostrar_sessoes_dia.Items[escolherSessao] is Sessao sessao)
            {
                var db = new ApplicationContext();
                var idsessao = db.Sessoes.Find(sessao.Id); // buscar o id da sessao q queremos mandar para o formatendimento
                if (idsessao != null) // so faz isso se uma sessao
                {   int idSessao = idsessao.Id;
                    int idFuncionario = getIdFuncionario();
                    this.formAtendimento.setConfigSala(idSessao, idFuncionario);
                    this.formAtendimento.ShowDialog(this);

                }
            }
        }
    }
}
