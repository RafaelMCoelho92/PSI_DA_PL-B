﻿using System;
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


            if (toolStripStatusLabelNomeFuncionarioLogado.Text == "")
            {
                tabControlMenuPrincipal.TabPages.Clear();
                TabPage tab = new FormLogin().getPage();
                tabControlMenuPrincipal.TabPages.Add(tab);
            }

            // APOS VERIFICAR O FUNC LOGADO, APRESENTARÁ O FORMULÁRIO PRINCIPAL COM A TAB DAS SESSOES DO DIA
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tabSessDia = new FormSessoesDoDia().getPage();
            tabControlMenuPrincipal.TabPages.Add(tabSessDia);
        }
        
        //VER SE TEM UTILIZADOR LOGADO CASO NAO TENHA VAI CHAMAR A PAGINA DE LOG IN
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            ApplicationContext context = new ApplicationContext();
            bool existem_cinemas = context.Cinemas.Count() > 0;

            if (!existem_cinemas)
            {
                do
                {
                    FormCinema formCinema = new FormCinema();
                    DialogResult resultado = formCinema.ShowDialog();

                    DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        this.Close();
                        return; // Encerra o método e fecha a aplicação
                    }
                    else if (resposta == DialogResult.No)
                    {
                        tabControlMenuPrincipal.TabPages.Clear();
                        TabPage tab = formCinema.getPage();
                        tabControlMenuPrincipal.TabPages.Add(tab);
                    }
                }
                while (context.Cinemas.Count() == 0); // Loop infinito
            }
            else
            {
                tabControlMenuPrincipal.TabPages.Clear();
                TabPage tab = new FormFuncionarios().getPage();
                tabControlMenuPrincipal.TabPages.Add(tab);
            }
            
            
        }

        // TAB CONTROL
        private void tabControlMenuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // MOSTRA A DATA E A HORA 
        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)
        }

        //CHAMA A TAB DOS CLIENTES
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormClientes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DAS SESSOES DO DIA CLICANDO NA LABEL DO TITULO DO CINEMA
        private void labelNomeCinema_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSessoesDoDia().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
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
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormCinema(this).getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DAS SALAS
        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSala().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DOS FUNCIONAROS
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormFuncionarios().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DAS SESSOES
        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSessoes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DOS FILMES
        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormFilmes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // CHAMA A TAB DAS SESSOES DO DIA
        private void sessãoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSessoesDoDia().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        // MÉTODO PARA ATUALIZAR A LABEL COM O TITULO DO CINEMA
        public void setNomeCinema(string nomeCinema)
        {
            labelNomeCinema.Text = nomeCinema;
        }

        // MÉTODO PARA ATUALIZAR A LABEL COM O NOME DO FUNCIONARIO LOGADO
        public void setNomeFuncionario(string nomePessoa)
        {
            toolStripStatusLabelNomeFuncionarioLogado.Text = nomePessoa;
        }

        private void toolStripStatusLabelNomeFuncionarioLogado_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormFuncionarios().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
    }
}
