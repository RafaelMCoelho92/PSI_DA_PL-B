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
    public partial class FormCategorias : Form
    {
        private FormPrincipal formPrincipal;

        public FormCategorias()
        {
            InitializeComponent();
        }
        public FormCategorias(FormPrincipal formPrincipal) : this()
        {
            this.formPrincipal = formPrincipal;
        }

        private void buttonAlterarEstado_Click(object sender, EventArgs e)
        {
            var db = new ApplicationContext();
            if (listBoxCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Categoria categoriaSelecionada = (Categoria)listBoxCategorias.SelectedItem;
                comboBoxEstadoCategoria.Text = categoriaSelecionada.estado;
                if (categoriaSelecionada.estado == "Ativa")
                {
                    categoriaSelecionada.estado = "Inativa";
                }
                else
                {
                    categoriaSelecionada.estado = "Ativa";
                }
                db.Categorias.AddOrUpdate(categoriaSelecionada);
                db.SaveChanges();
                limparSelecao();
                atualizarListBox();
            }
        }
        private void atualizarListBox()
        {
            listBoxCategorias.Items.Clear();

            using (var db = new ApplicationContext())
            {
                var categorias = db.Categorias.ToList();

                foreach (var categoria in categorias)
                {
                    listBoxCategorias.Items.Add(categoria.ToString());
                }
            }
        }
        private void limparSelecao()
        {
            textBoxNomeCategoria.Clear();
            listBoxCategorias.ClearSelected();
            comboBoxEstadoCategoria.Text = "Ativa";
        }
        private void FormCategorias_Load(object sender, EventArgs e)
        {
            var db = new ApplicationContext();
            var categorias = db.Categorias.ToList();
            listBoxCategorias.Items.Clear();
            if (categorias.Count == 0)
            {
                var categoriasPredefinidas = new string[] { "Comédia", "Sci-Fi", "Terror", "Romance", "Acção", "Thriller", "Drama", "Mistério", "Crime", "Aventura", "Fantasia", "Animação" };
                foreach (string categoria in categoriasPredefinidas)
                {
                    var novaCategoria = new Categoria { categoria = categoria, estado = "Ativa" };
                    db.Categorias.Add(novaCategoria);
                    listBoxCategorias.Items.Add(novaCategoria);
                }
                db.SaveChanges();
            }
            else
            {
                foreach (Categoria categoria in categorias)
                {
                    listBoxCategorias.Items.Add(categoria);
                }
            }
            limparSelecao();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int apagarCategoria = listBoxCategorias.SelectedIndex;
            if (apagarCategoria == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione uma categoria!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxCategorias.Items[apagarCategoria] is Categoria categoria)
            {
                // apaga da listbox
                listBoxCategorias.Items.Remove(categoria);
                //apaga da base de dados
                var db = new ApplicationContext();
                var categoriaSelecionada = db.Categorias.Find(categoria.Id); // buscar o id da categoria q queremos apagar
                if (categoriaSelecionada != null) // so faz isso se tiver uma categoria
                {
                    db.Categorias.Remove(categoriaSelecionada); // remove categoria pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                    limparSelecao();
                }
            }

        }

        private void FormCategorias_Click(object sender, EventArgs e)
        {
            limparSelecao();
        }

        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCategorias.SelectedIndex  != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Categoria categoriaSelecionada = (Categoria)listBoxCategorias.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    // mostrar na textBox os dados selecionados
                    textBoxNomeCategoria.Text = categoriaSelecionada.categoria;
                    comboBoxEstadoCategoria.Text = categoriaSelecionada.estado;
                }
            }
            else
            {
                return;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string categoria = textBoxNomeCategoria.Text;
            string estado = comboBoxEstadoCategoria.Text;
            if (categoria.Length == 0)
            {
                MessageBox.Show("O nome da categoria não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxCategorias.SelectedIndex != -1)
            {
                Categoria categoriaSelecionada = (Categoria)listBoxCategorias.SelectedItem;
                // altera dos dados da cat selecionada
                categoriaSelecionada.categoria = textBoxNomeCategoria.Text;
                categoriaSelecionada.estado = comboBoxEstadoCategoria.Text;
                // Atualizar a exibição da cat na ListBox
                int editarCategoria = listBoxCategorias.SelectedIndex;
                listBoxCategorias.Items[editarCategoria] = categoriaSelecionada;

                using (var db = new ApplicationContext())
                {   //faz update da cat
                    db.Categorias.AddOrUpdate(categoriaSelecionada);
                    db.SaveChanges();
                }
            }
            else
            {
                Categoria novaCategoria = new Categoria(textBoxNomeCategoria.Text, comboBoxEstadoCategoria.Text);

                listBoxCategorias.Items.Add(novaCategoria);
                using (var db = new ApplicationContext())
                {   // cria nova cat
                    db.Categorias.Add(novaCategoria);
                    db.SaveChanges();
                }
            }
            limparSelecao();
        }
    }
}
