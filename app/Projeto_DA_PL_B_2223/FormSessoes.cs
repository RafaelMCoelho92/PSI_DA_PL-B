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
    public partial class FormSessoes : Form
    {
        private FormPrincipal formPrincipal;

        public FormSessoes()
        {
            InitializeComponent();
            this.CenterToScreen();
            atualizarDadosAoEntrar();

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
                var filmes = db.Filmes.ToList();
                listBoxFilmesSessoes.DataSource = null;
                listBoxFilmesSessoes.DataSource = filmes;

                var salas = db.Salas.ToList();
                listBoxSalasSessoes.DataSource = null;
                listBoxSalasSessoes.DataSource = salas;

                /*var sessoes = db.Sessoes.ToList();
                listBoxSessoes.DataSource = null;
                listBoxSessoes.DataSource = sessoes;*/
            }
            /*
            using (var db = new ApplicationContext())
            {
                // VAI BUSCAR À BASE DE DADOS TODOS OS FILMES GUARDADOS E APRESENTA-OS NA LISTBOX DOS FILMES
                    
                    var filmes = db.Filmes.ToList();
                    listBoxFilmesSessoes.DataSource = null;
                    listBoxFilmesSessoes.DataSource = filmes;

                    var salas = db.Salas.ToList();
                    listBoxSalasSessoes.DataSource = null;
                    listBoxSalasSessoes.DataSource = salas;

                    var sessoes = db.Sessoes.ToList();
                    listBoxSessoes.DataSource = null; // Escrever o que está na toString do (class) Sessao 
                    listBoxSessoes.DataSource = sessoes;
                
                /*catch (Exception)
                {
                    MessageBox.Show("Não há filmes a adicionar à lista!");
                    return;
                }
                // VAI BUSCAR À BASE DE DADOS TODAS AS SALAS GUARDADAS E APRESENTA-AS NA LISTBOX DAS SALAS
                try
                {
                    var salas = db.Salas.ToList();
                    listBoxSalasSessoes.DataSource = null;
                    listBoxSalasSessoes.DataSource = salas;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não há salas a adicionar à lista!");
                    return;
                }
                // VAI BUSCAR À BASE DE DADOS TODAS AS SESSÕES JÁ CRIADAS E APRESENTA-AS NA LISTBOX DAS SESSÕES
                try
                {
                    var sessoes = db.Sessoes.ToList();
                    listBoxSessoes.DataSource = null; // Escrever o que está na toString do (class) Sessao 
                    listBoxSessoes.DataSource = sessoes;
                }*/


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

            /*DateTime horaSelecionado = dateTimePickerSessao.Value;
            if (horaSelecionado != DateTime.MinValue )
            {
                MessageBox.Show("Tem que selecionar uma data!");
                return false;
            }*/

            return true;
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.ClearSelected();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            listBoxFilmesSessoes.ClearSelected();
            listBoxSalasSessoes.ClearSelected();
            listBoxSessoes.ClearSelected();
        }

        private void buttonCriarSessoes_Click(object sender, EventArgs e)
        {
            string filme = listBoxFilmesSessoes.SelectedIndex.ToString();
            string sala = listBoxSalasSessoes.SelectedIndex.ToString();
            validarDadosSessoes();
            if (listBoxFilmesSessoes.SelectedIndex >= 0 && listBoxSalasSessoes.SelectedIndex >= 0)
            {
                atualizarDadosAoEntrar();
            }

            Sessao sessao = new Sessao(filme, sala);
            listBoxSessoes.Items.Add(sessao);

            /*
            
                Sessao sessao = new Sessao(filme, sala);
                listBoxSessoes.Items.Add(sessao);
                db.Sessoes.Add(sessao);
                db.SaveChanges();
            }*/
        }
    }
}
