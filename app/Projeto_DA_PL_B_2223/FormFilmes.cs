﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormFilmes : Form
    {
        private FormPrincipal formPrincipal;

        public FormFilmes()
        {
            InitializeComponent();
            atualizarListboxFilmesaoEntrar();
        }

        public FormFilmes(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }

        // METODO PARA CHAMAR NO FORM PRINCIPAL A PAGE DA TAB
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        public bool validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            string nomeFilme = textBoxNomeFilme.Text;
            if (nomeFilme.Length == 0)
            {
                MessageBox.Show("Insira o nome do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            if (categoriaFilme.Length == 0)
            {
                MessageBox.Show("Escolha uma categoria do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string estadoFilme = comboBoxEstadoFilme.Text;
            if (estadoFilme.Length == 0)
            {
                MessageBox.Show("Escolha o estado do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxCategoriaFilme.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha uma categoria da lista!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxEstadoFilme.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha o estado do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimePickerDuracao.Value.TimeOfDay == TimeSpan.Zero)
            {
                MessageBox.Show("Insira uma duração para o filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO PARA GUARDAR O FILME
        private void buttonGuardarFilme_Click(object sender, EventArgs e)
        {
            string nomeFilme = textBoxNomeFilme.Text;
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            string estadoFilme = comboBoxEstadoFilme.Text;
            TimeSpan hora = TimeSpan.Parse(dateTimePickerDuracao.Text);
            if (!validarDadosInseridos())
            {
                return;
            }
            try
            {   // manda para o construtor faz a instancia
                Filme filme = new Filme(nomeFilme, categoriaFilme, estadoFilme, hora);
            }
            catch (Exception)
            {   // caso haja algum erro
                MessageBox.Show("Erro ao criar o filme!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (listBoxFilmes.SelectedIndex != -1) // se tiver um funcionario selecionado, altera os dados
            {
                Filme filmeSelecionado = (Filme)listBoxFilmes.SelectedItem;
                // altera dos dados do filme selecionado
                filmeSelecionado.nomeFilme = textBoxNomeFilme.Text;
                filmeSelecionado.categoriaFilme = comboBoxCategoriaFilme.Text;
                filmeSelecionado.estadoFilme = comboBoxEstadoFilme.Text;
                filmeSelecionado.Duracao = TimeSpan.Parse(dateTimePickerDuracao.Text);
                // Atualizar a exibição dos filmes na ListBox
                int editarFilme = listBoxFilmes.SelectedIndex;
                listBoxFilmes.Items[editarFilme] = filmeSelecionado;

                using (var db = new ApplicationContext())
                {   //faz update do funcionario
                    db.Filmes.AddOrUpdate(filmeSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Filme novofilme = new Filme(textBoxNomeFilme.Text, comboBoxCategoriaFilme.Text, comboBoxEstadoFilme.Text, TimeSpan.Parse(dateTimePickerDuracao.Text));

                listBoxFilmes.Items.Add(novofilme); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria novo filme
                    db.Filmes.Add(novofilme);
                    db.SaveChanges();
                }
            }
        }

        //METODO PARA ATUALIZAR A LISTBOX
        public void atualizarListboxFilmesaoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var filmes = db.Filmes;
                foreach (var filme in filmes) //correr os funcionarios para os adicionar à listBox 
                {
                    listBoxFilmes.Items.Add(filme);
                }
            }
        }

        public void preencherComboBoxCategorias()
        {
            var db = new ApplicationContext();
            var categorias = db.Categorias.Where(c => c.estado == "Ativa").ToList();
            if (categorias.Count == 0)
            {
                criarCategoriasCasoVazio();
                categorias = db.Categorias.Where(c => c.categoria == "Ativa").ToList();
            }
            string[] categoriasCombo = categorias.Select(c => c.categoria).ToArray() ;// vamos ter q ir buscar a bd, caso a bd esteja vazia criamos tal e qual como esta no form categoria
            comboBoxCategoriaFilme.Items.AddRange(categoriasCombo);// vamos por essa lista na combobox
            comboBoxCategoriaFilme.SelectedIndex = 0; // vamos por logo uma opcao selecionada
        }
        public void criarCategoriasCasoVazio()
        {
            var db = new ApplicationContext();
            var categorias = db.Categorias.ToList();
            if (categorias.Count == 0)
            {
                var categoriasPredefinidas = new string[] { "Comédia", "Sci-Fi", "Terror", "Romance", "Acção", "Thriller", "Drama", "Mistério", "Crime", "Aventura", "Fantasia", "Animação" };
                foreach (string categoria in categoriasPredefinidas)
                {
                    var novaCategoria = new Categoria { categoria = categoria, estado = "Ativa" };
                    db.Categorias.Add(novaCategoria);
                }
                db.SaveChanges();
            }
        }
        private void listBoxFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherFilme = listBoxFilmes.SelectedIndex;
            if (escolherFilme != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Filme filmeEscolhido = (Filme)listBoxFilmes.SelectedItem;
                    textBoxNomeFilme.Text = filmeEscolhido.nomeFilme;
                    comboBoxCategoriaFilme.Text = filmeEscolhido.categoriaFilme;
                    comboBoxEstadoFilme.Text = filmeEscolhido.estadoFilme;

                    // ESTAS TRÊS LINHAS SEGUINTES APRESENTAM O VALOR DA DURAÇÃO DO FILME NA LISTBOX DO SELECTEDINDEX
                    DateTime new_date = dateTimePickerDuracao.MinDate.AddHours(filmeEscolhido.Duracao.Hours);
                    new_date = new_date.AddMinutes(filmeEscolhido.Duracao.Minutes);
                    dateTimePickerDuracao.Value = new_date;
                }
            }
        }

        private void buttonApagarFilme_Click(object sender, EventArgs e)
        {
            int apagarFilme = listBoxFilmes.SelectedIndex;
            if (apagarFilme == -1)
            {
                // se n tiver filme selecionado mensagem de erro
                MessageBox.Show("Selecione um Filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxFilmes.Items[apagarFilme] is Filme filme)
            {
                listBoxFilmes.Items.Remove(filme);
                var db = new ApplicationContext();
                var apagarfilme = db.Filmes.Find(filme.Id); // buscar o id do filme q queremos apagar
                if (apagarfilme != null) // so faz isso se tiver um filme
                {
                    db.Filmes.Remove(apagarfilme); // remove filme pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxFilmes.ClearSelected();
            limparDadosInseridos();
        }

        private void FormFilmes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBoxFilmes.ClearSelected();
            limparDadosInseridos();
            preencherComboBoxCategorias();
            comboBoxEstadoFilme.Text = "Desativado";
        }

        public void limparDadosInseridos()
        {
            textBoxNomeFilme.Clear();
            dateTimePickerDuracao.Value = dateTimePickerDuracao.Value.Date.AddHours(0).AddMinutes(0);
        }
    }
}