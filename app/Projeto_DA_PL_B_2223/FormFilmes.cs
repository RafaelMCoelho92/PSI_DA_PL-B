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
        }
        // METODO PARA CHAMAR NO FORM PRINCIPAL A PAGE DA TAB
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }
        //METODO PARA GUARDAR O FILME
        private void buttonGuardarFilme_Click(object sender, EventArgs e)
        {
            string nomeFilme = textBoxNomeFilme.Text;
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            string estadoFilme = comboBoxEstadoFilme.Text;
            validarDadosInseridos(); // VALIDAR DADOS INSERIDOS
            if (nomeFilme.Length > 0 && categoriaFilme.Length > 0)
            {
                atualizarListboxFilmes(nomeFilme, categoriaFilme, estadoFilme);
            }

        }
        //METODO PARA ATUALIZAR A LISTBOX
        public void atualizarListboxFilmes(string nomeFilme, string categoriaFilme, string estadoFilme)
        {
            Filme filme = new Filme(nomeFilme, categoriaFilme, estadoFilme);
            listBoxFilmes.Items.Add(filme);
        }
        //METODO PARA VALIDAR DADOS INSERIDOS
        public void validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            string nomeFilme = textBoxNomeFilme.Text;
            if (nomeFilme.Length == 0)
            {
                MessageBox.Show("Insira o nome do filme");
                return;
            }
            string categoriaFilme = comboBoxCategoriaFilme.Text;
            if (categoriaFilme.Length == 0)
            {
                MessageBox.Show("Escolha uma categoria do filme");
                return;
            }
            string estadoFilme = comboBoxEstadoFilme.Text;
            if (estadoFilme.Length == 0)
            {
                MessageBox.Show("Escolha o estado do filme");
                return;
            }
        }
        
    }
}
