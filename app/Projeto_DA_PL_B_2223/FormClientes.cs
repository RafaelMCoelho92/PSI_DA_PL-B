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
    public partial class FormClientes : Form
    {
        private FormPrincipal formPrincipal;

        public FormClientes()
        {
            InitializeComponent();
            atualizarDadosAoEntrar();

        }
        public FormClientes(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }
        public TabPage getPage()
        {
            return tabPage1;
        }
        private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var clientes = db.Pessoas.OfType<Cliente>();
                foreach (var cliente in clientes) //correr os clientes para os adicionar à listBox 
                {
                    listBoxClientes.Items.Add(cliente); 
                }
            }

        }
        private void buttonGuardarClientes_Click(object sender, EventArgs e)
        {
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            string nomeCliente = textBoxNomeClientes.Text;
            if (nomeCliente.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio");
                return;
            }
            string moradaCliente = textBoxMoradaClientes.Text;
            if (moradaCliente.Length == 0)
            {
                MessageBox.Show("A morada não pode ser vazia");
                return;
            }
            string numFiscCliente = textBoxNumFiscClientes.Text;
            if (numFiscCliente.Length == 0)
            {
                MessageBox.Show("É necessário um número fiscal");
                return;
            }

            // VARIAVEL PARA FAZER O PARSE
            double contribuinte = 0;

            try
            {
                // FAZ O PARSE DE STRING PARA DOUBLE - APENAS PERMITE A INSERÇÃO DE NUMEROS
                contribuinte = double.Parse(numFiscCliente);

                // VERIFICA CASO O NUMERO NAO SEJA COMPREENDIDO ENTRE OS VALORES INSERIDOS - MOSTRA O ERRO
                if (contribuinte < 100000000 || contribuinte >= 700000000)
                {
                    MessageBox.Show("O número fiscal a inserir deve ser válido");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas devem constar números neste campo");
            }

            VerificaClienteExistente(nomeCliente, moradaCliente, numFiscCliente);

            // GUARDAR OS DADOS DOS CLIENTES NA BASE DE DADOS
            using (var db = new ApplicationContext())
            {
                var cliente = new Cliente(textBoxNomeClientes.Text, textBoxMoradaClientes.Text, textBoxNumFiscClientes.Text);
                db.Pessoas.Add(cliente);
                db.SaveChanges();
            }

        }

        // METODO PARA VERIFICAR SE JA EXISTE ALGUM CLIENTE NA LISTBOX DOS CLIENTES
        private void VerificaClienteExistente(string nomeCliente, string moradaCliente, string numFiscCliente)
        {
            foreach (Cliente clienteExistente in listBoxClientes.Items)
            {
                if (clienteExistente.NumFiscCliente == numFiscCliente)
                {
                    MessageBox.Show("Não pode adicionar um cliente com um Numero Fiscal já utilizado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // NUMERO FISCAL DO CLIENTE JA EXISTE
                }
            }

            // INSTANCIADO O OBJ CLIENTE E ENVIA PARA A LISTA DE CLIENTES
            Cliente cliente = new Cliente(nomeCliente, moradaCliente, numFiscCliente);
            textBoxNomeClientes.Text = cliente.NomePessoa;
            textBoxMoradaClientes.Text = cliente.MoradaPessoa;
            textBoxNumFiscClientes.Text = cliente.NumFiscCliente;

            listBoxClientes.Items.Add(cliente);
            return; // NUMERO FISCAL DO CLIENTE NAO EXISTE
        }
        private void buttonApagarClientes_Click(object sender, EventArgs e)
        {
            int apagarCliente = listBoxClientes.SelectedIndex;
            if (apagarCliente == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Cliente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxClientes.Items[apagarCliente] is Cliente cliente)
            {
                //se tiver cliente selecionado
                // apaga da listbox
                listBoxClientes.Items.Remove(cliente);
                //apaga da base de dados
                var db = new ApplicationContext();
                var apagarcliente = db.Pessoas.Find(cliente.Id); // buscar o id do cliente q queremos apagar
                if (apagarcliente != null) // so faz isso se tiver um cliente
                {
                    db.Pessoas.Remove(apagarcliente); // remove cliente pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxClientes.ClearSelected();
            limparDadosInseridos();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBoxClientes.ClearSelected();
            limparDadosInseridos();
        }
        private void limparDadosInseridos()
        {
            textBoxNomeClientes.Clear();
            textBoxMoradaClientes.Clear();
            textBoxNumFiscClientes.Clear();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherCliente = listBoxClientes.SelectedIndex;
            if (escolherCliente != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    // mostrar na textBox os dados do cliente selecionado                                                                                   
                    textBoxNomeClientes.Text = clienteSelecionado.NomePessoa;
                    textBoxMoradaClientes.Text = clienteSelecionado.MoradaPessoa;
                    textBoxNumFiscClientes.Text = clienteSelecionado.NumFiscCliente;

                }

            }
        }
    }

}
