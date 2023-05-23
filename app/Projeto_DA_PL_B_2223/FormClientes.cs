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

                // INSTANCIADO O OBJ CLIENTE E ENVIA PARA A LISTA DE CLIENTES ---> (POSTEIRORMENTE PARA ADICIONAR A UMA LISTA)
                Cliente cliente = new Cliente(nomeCliente, moradaCliente, numFiscCliente);
                textBoxNomeClientes.Text = cliente.NomePessoa;
                textBoxMoradaClientes.Text = cliente.MoradaPessoa;
                textBoxNumFiscClientes.Text = cliente.NumFiscCliente;

                string clienteInfo = $"Nome: {nomeCliente}   " +
                                     $"Morada: {moradaCliente}   " +
                                     $"Número Fiscal: {numFiscCliente}";

                // APENAS ADICIONA CLIENTES À LISTA CASO O CAMPO DO NUMERO FISCAL ESTEJA INSERIDO CORRETAMENTE
                listBoxClientes.Items.Add(clienteInfo);

            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas devem constar números neste campo");
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
}
