using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormEstadoBilhete : Form
    {
        private FormPrincipal formPrincipal;
        public FormEstadoBilhete()
        {
            InitializeComponent();
            atualizarDadosAoEntrar();
        }

        public FormEstadoBilhete(FormPrincipal formPrincipal) : this()
        {
            this.formPrincipal = formPrincipal;
        }

        private void atualizarDadosAoEntrar()
        {
            listBox_pesquisaIdBilhete.Items.Clear();

            using (var db = new ApplicationContext())
            {
                var bilhetes = db.Bilhetes.OfType<Bilhete>();
                
                foreach (var bilhete in bilhetes)
                {
                    var cliente = db.Pessoas.OfType<Cliente>().First(c => c.Id == bilhete.idCliente);
                    listBox_pesquisaIdBilhete.Items.Add(bilhete).ToString();
                }
            }
        }

        private void button_pesquisaIdBilhete_Click(object sender, EventArgs e)
        {
            string valorPesquisa = textBox_pesquisaIdBilhete.Text;
            if (!string.IsNullOrEmpty(valorPesquisa))
            {
                using (var db = new ApplicationContext())
                {
                    // Realiza a consulta no banco de dados
                    var idBilhete = db.Bilhetes.OfType<Bilhete>().FirstOrDefault(b => b.idBilhete.ToString() == valorPesquisa);

                    if (idBilhete != null)
                    {
                        listBox_pesquisaIdBilhete.Items.Clear();
                        listBox_pesquisaIdBilhete.Items.Add(idBilhete);
                    }
                    else
                    {
                        MessageBox.Show("Bilhete não encontrado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um valor para pesquisa!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_mudarEstadoBilhete_Click(object sender, EventArgs e)
        {
            var db = new ApplicationContext();

            if (listBox_pesquisaIdBilhete.Items.Count == -1)
            {
                MessageBox.Show("Selecione um bilhete para alterar estado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Bilhete bilheteSelecionado = (Bilhete)listBox_pesquisaIdBilhete.SelectedItem;
                textBox_estado.Text = bilheteSelecionado.estadoBilhete;
                if (bilheteSelecionado.estadoBilhete == "Activo")
                {
                    bilheteSelecionado.estadoBilhete = "Inactivo";
                } else
                {
                    bilheteSelecionado.estadoBilhete = "Activo";
                }
                db.Bilhetes.AddOrUpdate(bilheteSelecionado);
                db.SaveChanges();
            }
             
            atualizarDadosAoEntrar();
            textBox_estado.Clear();
        }

        private void listBox_pesquisaIdBilhete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherBilhete = listBox_pesquisaIdBilhete.SelectedIndex;
            if (escolherBilhete != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Bilhete bilheteSelecionado = (Bilhete)listBox_pesquisaIdBilhete.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    textBox_estado.Text = bilheteSelecionado.estadoBilhete;
                }

            }
        }
    }
}
