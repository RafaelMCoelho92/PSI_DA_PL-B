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
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }
        // ADICIONA UMA SALA NA LIST BOX
        private void buttonAdicionarSala_Click(object sender, EventArgs e)
        {
            string nomeSala = textBoxNomeSala.Text;
                if (nomeSala.Length == 0 )
                {
                    MessageBox.Show("O nome da sala não pode ser vazio!", "Aviso!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            Sala sala = new Sala(nomeSala);
            listBoxSalas.Items.Add(sala);

        }
        // ALTERA AS FILAS E AS COLUNAS EM UMA SALA
        private void buttonEditarFilasColunas_Click(object sender, EventArgs e)
        {
            //RECEBE AS DUAS VARIAVEIS EM STRING
            string fila = textBoxFilas.Text;
            string coluna = textBoxColunas.Text;
            //VALIDA QUE NENHUMA DELAS ESTA VAZIA
            if (fila.Length == 0  || coluna.Length == 0)
            {
                MessageBox.Show("Não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //VERIFICAR QUE ESTA SELECIONADA A SALA DA LISTBOX
            int index_selecionado = listBoxSalas.SelectedIndex;
            if (index_selecionado == -1)
            {
                MessageBox.Show("Selecione uma sala da lista!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // VARIAVEIS PARA UTILIZAR NO PARSE
            double valorFila = 0;
            double valorColuna = 0;

            try
            {   // FAZER O PARSE-> OU SEJA PASSAR DE STRING PARA DOUBLE
                valorFila = double.Parse(fila);
                valorColuna = double.Parse(coluna);
                // CASO VALOR SEJA MENOR OU IGUAL A ZERO-> MENSAGEM DE ERRO
                if (valorFila <= 0 || valorColuna <= 0) 
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser superior a 0 (zero)!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // CASO VALOR SEJA MAIOR QUE 20 -> MENSAGEM DE ERRO
                if(valorFila > 20 || valorColuna > 20)
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser inferior a 20!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // CASO NAO SEJA NUMERO 
            catch (Exception)
            {
                MessageBox.Show("Valor Invalido, insira um valor entre 1 e 20!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {   
                Sala sala = listBoxSalas.Items[index_selecionado] as Sala; // CAST
                sala.Alterar(valorFila, valorColuna); // VAI ALTERAR O VALOR DAS LINHAS E COLUNAS DA SALA
                listBoxSalas.Items[index_selecionado] = sala; //Atualiza a listbox
            }
            catch(Exception) 
            {   // caso haja algum erro
                MessageBox.Show("Não é uma sala!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 

        }
        // APAGA UMA SALA E AS FILAS E COLUNAS
        private void buttonApagarSala_Click(object sender, EventArgs e)
        {
            int salaSelecionada = listBoxSalas.SelectedIndex;
            if (salaSelecionada == -1)
                {
                    MessageBox.Show("Selecione uma sala!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            Sala sala = listBoxSalas.Items[salaSelecionada] as Sala;
            listBoxSalas.Items.Remove(sala);           
        }
    }
}
