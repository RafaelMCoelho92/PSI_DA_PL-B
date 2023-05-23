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
        public FormClientes()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabPage1;
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
                VerificaClienteExistente(nomeCliente, moradaCliente, numFiscCliente);


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

            // APENAS ADICIONA CLIENTES À LISTA CASO O CAMPO DO NUMERO FISCAL ESTEJA INSERIDO CORRETAMENTE
            listBoxClientes.Items.Add(cliente);
            return; // NUMERO FISCAL DO CLIENTE NAO EXISTE
        }



        /*
             CRIAR LISTA DE CLIENTES
             List<Cliente> clientes = new List<Cliente>();

             PERCORRER TODOS OS CLIENTES EXISTENTES NA LISTA DE MODO A VERIFICAR SE HA ALGUM NIF REPETIDO 
             foreach (Cliente clienteExistente in clientes)
             {
                if (clienteExistente.NumFiscCliente == numFiscCliente)
                {
                    MessageBox.Show("Este número fiscal já foi inserido anteriormente");
                    return;
                }
            }

            APÓS CRIADA A LISTA E VERIFICADO QUE NÃO HA NUMERO REPETIDO ADICIONA O OBJ CLIENTE À LISTA 
            clientes.Add(cliente);
         */
    }
}
