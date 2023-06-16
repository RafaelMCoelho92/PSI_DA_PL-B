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
                    listBox_pesquisaIdBilhete.Items.Add("ID Bilhete: " + bilhete.idBilhete + 
                        " | Lugar Bilhete: " + bilhete.lugarBilhete + 
                        " | Estado Bilhete: " + bilhete.estadoBilhete +
                        " | Nome do Cliente: " + bilhete.idCliente); // REVER PARA PUXAR O NOME DO CLIENTE E NAO O ID
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
    }
}
