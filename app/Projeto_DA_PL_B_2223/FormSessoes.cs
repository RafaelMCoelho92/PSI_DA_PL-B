﻿using System;
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
    public partial class FormSessoes : Form
    {
        private FormPrincipal formPrincipal;

        public FormSessoes()
        {
            InitializeComponent();
            this.CenterToScreen();

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
                MessageBox.Show("Tem que selecionar um filme!");
                return false;
            }

            int salaSelecionado = listBoxSalasSessoes.SelectedIndex;
            if (salaSelecionado == -1)
            {
                MessageBox.Show("Tem que selecionar uma sala!");
                return false;
            }

            string precoInserido = textBoxPrecoSessoes.Text;
            if(precoInserido == null)
            {
                MessageBox.Show("Tem que inserir um preço para a sessão!");
                return false;
            }
            
          /*DateTime dataSelecionada = dateTimePickerDataSessao.Value;
            if (dataSelecionada != DateTime.MinValue )
            {
                MessageBox.Show("Tem que selecionar uma data!");
                return false;
            }
            
            DateTime horaSelecionada = dateTimePickerHoraSessao.Value;
             if (horaSelecionada != DateTime.MinValue )
            {
                MessageBox.Show("Tem que selecionar uma hora!");
                return false;
            }*/

            return true;
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.ClearSelected();
            listBoxSalasSessoes.Items.Clear();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            listBoxFilmesSessoes.Items.Clear();
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.Items.Clear();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.Items.Clear();
            listBoxSessoes.ClearSelected();
            atualizarDadosAoEntrar();

        }

        private void buttonCriarSessoes_Click(object sender, EventArgs e)
        {
            validarDadosSessoes();
            // ESTAVA A CRIAR A INSTANCIA NA MESMA, APÓS CRIAR SESSAO SEM NENHUM ITEM SELECIONADO E DAVA CRASH COM ESTE IF NÃO DÁ
            if (listBoxFilmesSessoes.SelectedIndex > 0 && listBoxSalasSessoes.SelectedIndex > 0)
            {
                string valorPreco = textBoxPrecoSessoes.Text.ToString();
                double preco = double.Parse(valorPreco);

                DateTime data = dateTimePickerDataSessao.Value;
                DateTime hora = dateTimePickerHoraSessao.Value;

                Filme filmeSelecionado = (Filme)listBoxFilmesSessoes.SelectedItem;
                Sala salaSelecionada = (Sala)listBoxSalasSessoes.SelectedItem;

                Sessao sessao = new Sessao(filmeSelecionado.nomeFilme, salaSelecionada.nomeSala, preco, data, hora);
                listBoxSessoes.Items.Add(sessao);

                using (var db = new ApplicationContext())
                {
                    var sessoes = db.Sessoes.ToList();
                    foreach (var s in sessoes) //correr os clientes para os adicionar à listBox 
                    {
                        listBoxSessoes.Items.Add(s);
                        db.Sessoes.Add(sessao);
                        db.SaveChanges();
                    }
                }
            }
            //atualizarDadosAoEntrar();
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
    }
}
