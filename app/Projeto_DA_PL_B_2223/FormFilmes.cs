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
    public partial class FormFilmes : Form
    {
        public FormFilmes()
        {
            InitializeComponent();
            this.CenterToScreen();
            atualizarListboxFilmesaoEntrar();

        }

        // METODO PARA CHAMAR NO FORM PRINCIPAL A PAGE DA TAB
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }
        public void validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            string nomeFilme = textBoxNomeFilme.Text;
            if (nomeFilme.Length == 0)
            {
                MessageBox.Show("Insira o nome do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            if (categoriaFilme.Length == 0)
            {
                MessageBox.Show("Escolha uma categoria do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string estadoFilme = comboBoxEstadoFilme.Text;
            if (estadoFilme.Length == 0)
            {
                MessageBox.Show("Escolha o estado do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxCategoriaFilme.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha uma categoria da lista!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxEstadoFilme.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha o estado do filme!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //METODO PARA GUARDAR O FILME
        private void buttonGuardarFilme_Click(object sender, EventArgs e)
        {
            
            string nomeFilme = textBoxNomeFilme.Text;
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            string estadoFilme = comboBoxEstadoFilme.Text;
            validarDadosInseridos(); // VALIDAR DADOS INSERIDOS
            if (nomeFilme.Length > 0 && comboBoxCategoriaFilme.SelectedIndex>=0 && comboBoxEstadoFilme.SelectedIndex >=0)
            {
                atualizarListboxFilmesaoEntrar();
            }

            using (var db = new ApplicationContext())
            {
                var filme = new Filme(nomeFilme, categoriaFilme, estadoFilme);
                db.Filmes.Add(filme);
                db.SaveChanges();
            }
        }
        //METODO PARA ATUALIZAR A LISTBOX
        public void atualizarListboxFilmesaoEntrar() 
        {
            //Filme filme = new Filme(nomeFilme, categoriaFilme, estadoFilme);
            // listBoxFilmes.Items.Add(filme);

            using (var db = new ApplicationContext())
            {

                var filmes = db.Filmes.ToList();
                listBoxFilmes.DataSource = null;
                listBoxFilmes.DataSource = filmes;                
            }

        }
        //METODO PARA VALIDAR DADOS INSERIDOS
        
        
    }
}
