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
            //VER SE TEM UTILIZADOR LOGADO CASO NAO TENHA VAI CHAMAR A PAGINA DE LOG IN

            if (toolStripStatusLabelNomeFuncionarioLogado.Text == "")
            {
                tabControlMenuPrincipal.TabPages.Clear();
                TabPage tab = new FormLogin().getPage();
                tabControlMenuPrincipal.TabPages.Add(tab);
            }
            

        }
        //VAI CHAMAR A TAB DO CINEMA
        private void buttonCinema_Click(object sender, EventArgs e)
        {           
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormCinema().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
            //FormCinema formCinema = new FormCinema(); // depois que trocar pra buscar da BD em vez do textbox
            //FormCinema.atualizarDadosLabel();
        }
        // CHAMA A TAB DOS FILMES
        private void buttonFilmes_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormFilmes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }

        //CHAMA A TAB DAS SESSOES
        private void buttonSessoes_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSessoes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
        //CHAMA A TAB DOS CLIENTES
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormClientes().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
        // CHAMA A TAB DOS FUNCIONARIOS
        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormFuncionarios().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
        // 
        private void tabControlMenuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // CHAMA A TAB DAS SALAS
        private void buttonSalas_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormSala().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
        
        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            // MOSTRA A DATA E A HORA 
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)



        }
        // CHAMA A TAB DOS FUNCIONARIOS
        private void buttonaAlterarFuncionario_Click(object sender, EventArgs e)
        {
            tabControlMenuPrincipal.TabPages.Clear();
            TabPage tab = new FormLogin().getPage();
            tabControlMenuPrincipal.TabPages.Add(tab);
        }
    }
}
