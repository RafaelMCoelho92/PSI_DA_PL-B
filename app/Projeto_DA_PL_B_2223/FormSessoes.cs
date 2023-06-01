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
                //correr as sessoes para os adicionar à listBox 
                try
                {
                    var filmes = db.Filmes.ToList();
                    listBoxFilmesSessoes.DataSource = null;
                    listBoxFilmesSessoes.DataSource = filmes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não há filmes a adicionar à lista!");
                    return;
                }


                var salas = db.Salas.ToList();
                listBoxSalasSessoes.DataSource = null;
                listBoxSalasSessoes.DataSource = salas;

                var sessoes = db.Sessoes.ToList();
                listBoxSessoes.DataSource = null; // Escrever o que está na toString do (class) Sessao 
                listBoxSessoes.DataSource = sessoes;
            }
        }

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

            DateTime horaSelecionado = dateTimePickerSessao.Value;
            if (horaSelecionado == DateTime.MinValue )
            {
                MessageBox.Show("Tem que selecionar uma data!");
                return false;
            }

            return true;
        }
    }
}
