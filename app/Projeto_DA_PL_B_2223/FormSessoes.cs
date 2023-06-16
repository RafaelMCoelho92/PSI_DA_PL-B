using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormSessoes : Form
    {
        private FormPrincipal formPrincipal;

        public FormSessoes()
        {
            InitializeComponent();
            dateTimePickerDataSessao.MinDate = DateTime.Now; // seleciona data de hoje pra frente
        }

        public FormSessoes(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var filmes = db.Filmes.Where(f => f.estadoFilme == "Ativado").ToList(); // mostra so os filmes que tem o estado Ativado,
                foreach (var filme in filmes) //correr os filmes que estao ativados para os adicionar à listBox 
                {
                    listBoxFilmesSessoes.Items.Add(filme);
                }
                using (var bd = new ApplicationContext())
                {
                    var sessoes = bd.Sessoes.ToList();
                    foreach (var sessao in sessoes) //correr os clientes para os adicionar à listBox 
                    {
                        listBoxSessoes.Items.Add(sessao);
                    }
                }
            }
        }

        // VALIDA SE OS INDEX ESTÃO SELECIONADOS
        public bool validarDadosSessoes()
        {
            int filmeSelecionado = listBoxFilmesSessoes.SelectedIndex;
            if (filmeSelecionado == -1)
            {
                MessageBox.Show("Tem que selecionar um filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int salaSelecionado = listBoxSalasSessoes.SelectedIndex;
            if (salaSelecionado == -1)
            {
                MessageBox.Show("Tem que selecionar uma sala!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string precoInserido = textBoxPrecoSessoes.Text;
            if (precoInserido == null)
            {
                MessageBox.Show("Tem que inserir um preço para a sessão!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.ClearSelected();
            listBoxSalasSessoes.Items.Clear();
            textBoxPrecoSessoes.Text = 0.ToString();
            dateTimePickerHoraSessao.Value = dateTimePickerHoraSessao.Value.Date.AddHours(10).AddMinutes(0);
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            listBoxFilmesSessoes.Items.Clear();
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.Items.Clear();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.Items.Clear();
            listBoxSessoes.ClearSelected();
            textBoxPrecoSessoes.Text = 0.ToString();
            dateTimePickerHoraSessao.Value = dateTimePickerHoraSessao.Value.Date.AddHours(10).AddMinutes(0);
            atualizarDadosAoEntrar();
        }

        private void buttonCriarSessoes_Click(object sender, EventArgs e)
        {
            validarDadosSessoes();

            // ESTAVA A CRIAR A INSTANCIA NA MESMA, APÓS CRIAR SESSAO SEM NENHUM ITEM SELECIONADO E DAVA CRASH COM ESTE IF NÃO DÁ
            if (listBoxFilmesSessoes.SelectedIndex > -1 && listBoxSalasSessoes.SelectedIndex > -1)
            {
                // se for vazio mensagem de erro 
                string valorPreco = textBoxPrecoSessoes.Text.ToString();
                if (valorPreco == "")
                {
                    MessageBox.Show("Digite o Preço do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    double preco = double.Parse(valorPreco);
                    string data = dateTimePickerDataSessao.Value.ToString("dd/MM/yyyy");
                    TimeSpan horaInicial = TimeSpan.Parse(dateTimePickerHoraSessao.Value.ToString("HH:mm"));
                    DateTime dataHoraSelecionada = dateTimePickerDataSessao.Value.Date.AddHours(horaInicial.Hours).AddMinutes(horaInicial.Minutes);
                    DateTime dataHoraAtual = DateTime.Now;

                    if (dataHoraSelecionada > dataHoraAtual)
                    {
                        Filme filmeSelecionado = (Filme)listBoxFilmesSessoes.SelectedItem;
                        Sala salaSelecionada = (Sala)listBoxSalasSessoes.SelectedItem;

                        Sessao sessao = new Sessao(filmeSelecionado.Id, salaSelecionada.Id, preco, data, horaInicial);
                        var db = new ApplicationContext();

                        TimeSpan duracaoFilme = db.Filmes.Single(f => f.Id == filmeSelecionado.Id).Duracao; // Obtém a duração do filme selecionado a partir da base de dados

                        TimeSpan duracaoExtra = TimeSpan.FromMinutes(30); // 30 minutos extras
                        TimeSpan duracaoTotal = duracaoFilme.Add(duracaoExtra); // duração total da sessão (filme + 30 minutos)
                        TimeSpan horaFim = horaInicial.Add(duracaoTotal); // horário de término da sessão

                        bool existeSessao = db.Sessoes.Any(s => s.Data == sessao.Data && s.idSala == salaSelecionada.Id &&
                            ((s.Hora <= horaInicial && DbFunctions.AddSeconds(s.Hora, (int)duracaoTotal.TotalSeconds) > horaInicial) ||
                            (s.Hora >= horaInicial && s.Hora < horaFim)));

                        ////////////////////////////////////////////////////// completei esta informação com o chat mas vou tentar explicar
                        // db.Sessoes.Any(...): O método Any verifica se existe algum elemento na coleção 
                        // s => ...O parâmetro s representa cada sessão na coleção
                        // esta tinha feito em aula s.Data == sessao.Data && s.idSala == salaSelecionada.Id: Verifica se a sessão atual tem a mesma data e sala que a sessão existente
                        //s.Hora >= horaInicial && s.Hora < horaFim: Verifica se a sessão existente começa depois do início da nova sessão (s.Hora >= horaInicial)
                        //e termina antes do horário de término da nova sessão (s.Hora < horaFim

                        if (existeSessao)
                        {
                            MessageBox.Show("A sala já está ocupada nesse horário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            listBoxSessoes.Items.Add(sessao);
                            var sessoes = db.Sessoes.ToList();
                            db.Sessoes.Add(sessao); // Adiciona a nova sessão ao contexto do banco de dados
                            db.SaveChanges(); // Salva as alterações no banco de dados
                        }
                    }
                    else
                    {
                        MessageBox.Show("A hora inserida da sessão deve ser superior à hora atual!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Apenas devem constar números neste campo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void listBoxFilmesSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSalasSessoes.Items.Clear();
            if (listBoxFilmesSessoes.SelectedIndex != -1)
            {
                using (var bd = new ApplicationContext())
                {
                    var salas = bd.Salas.ToList();
                    foreach (var sala in salas) //correr as salas para os adicionar à listBox 
                    {
                        listBoxSalasSessoes.Items.Add(sala);
                    }
                }
            }
        }

        private void button_apagar_sessoes_click(object sender, EventArgs e)
        {
            int apagarSessao = listBoxSessoes.SelectedIndex;
            if (apagarSessao == -1)
            {
                // se n tiver sessao selecionada mensagem de erro
                MessageBox.Show("Selecione uma Sessão!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxSessoes.Items[apagarSessao] is Sessao sessao)
            {
                //se tiver sessao selecionada
                // apaga da listbox
                listBoxSessoes.Items.Remove(sessao);
                //apaga da base de dados
                var db = new ApplicationContext();
                var sessaoApagar = db.Sessoes.Find(sessao.Id); // buscar o id da sessao que queremos apagar
                if (sessaoApagar != null) // so faz isso se tiver uma sessao
                {
                    db.Sessoes.Remove(sessaoApagar); // remove sala pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }
    }
}