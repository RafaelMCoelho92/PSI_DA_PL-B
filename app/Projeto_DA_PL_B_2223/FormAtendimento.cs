using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormAtendimento : Form
    {
        private FormPrincipal formPrincipal;
        public int idsessao;
        public FormAtendimento()
        {
            InitializeComponent();
            this.CenterToScreen();


        }

        public FormAtendimento(FormPrincipal formPrincipal) : this()
        {
            this.formPrincipal = formPrincipal;
            
        }


        
        public int getFilas(int Id)
        {
            var db = new ApplicationContext();
            var sessao = db.Sessoes.Find(Id); // procura a sessao pelo id recebido
            int idsala  = sessao.idSala ;  // ve qual o id da sala
            var filascolunas = db.Salas.Find(idsala); // vai buscar os dados da sala
            int filas = int.Parse(filascolunas.Fila); // faz o parse pra int da string com o valor das filas
            return filas;
        }
        public int getColunas(int Id)
        {
            var db = new ApplicationContext();
            var sessao = db.Sessoes.Find(Id); // procura a sessao pelo id recebido
            int idsala = sessao.idSala; // ve qual o id da sala
            var filascolunas = db.Salas.Find(idsala); // vai buscar os dados da sala
            int colunas = int.Parse(filascolunas.Coluna);// faz o parse pra int da string com valor das colunas
            return colunas;
        }
        public void setConfigSala(int id)
        {
            int filas = getFilas(id);
            int colunas = getColunas(id);
            tableLayoutPanelEscolherLugar.SuspendLayout();

            tableLayoutPanelEscolherLugar.Controls.Clear();
            tableLayoutPanelEscolherLugar.RowCount = filas;
            tableLayoutPanelEscolherLugar.ColumnCount = colunas;
            idsessao = id;
            

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Button button = new LugarButton(i, j);
                    button.Size = new Size(50, 25);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    button.BackColor =  Color.Green;
                    button.ForeColor = Color.Black;
                    //button.Image = Properties.Resources.chair5381;
                    button.Click += LugarClicked;
                    tableLayoutPanelEscolherLugar.Controls.Add(button, j, i);
                }
            }
            tableLayoutPanelEscolherLugar.ResumeLayout();
        }
        private void LugarClicked(Object sender, EventArgs e)
        {
            LugarButton button = (LugarButton)sender;
            var db = new ApplicationContext();
            //MessageBox.Show("Fila: " + button.X + " Coluna: " + button.Y + " Selecionada."); NAO APAGAR PODE SER UTIL
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Red;
                listBox_lugaresSelecionados.Items.Add(button.Text);
                double valor= double.Parse(textBox_valorBilhete.Text);
                var sessao = db.Sessoes.Find(idsessao);
                valor += sessao.Preco;
               textBox_valorBilhete.Text =  valor.ToString();
            }
            else if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Green;
                listBox_lugaresSelecionados.Items.Remove(button.Text);
                double valor = double.Parse(textBox_valorBilhete.Text);
                var sessao = db.Sessoes.Find(idsessao);
                valor -= sessao.Preco;
                textBox_valorBilhete.Text = valor.ToString();


            }
        }

        public void buttonPesquisarNif_Click(object sender, EventArgs e)
        {
            // Verifica se o radiobutton "radioButton_cliente" está selecionado
            if (radioButton_cliente.Checked)
            {
                // Obtém o valor da caixa de texto de pesquisa
                string valorPesquisa = textBox_pesquisa.Text;

                if (!string.IsNullOrEmpty(valorPesquisa))
                {
                    using (var db = new ApplicationContext())
                    {
                        // Realiza a consulta no banco de dados
                        var nifCliente = db.Pessoas.OfType<Cliente>()
                            .FirstOrDefault(p => p.NumFiscCliente == valorPesquisa);

                        if (nifCliente != null)
                        {   //coloca o que está na base de dados nas textBoxs
                            textBox_nomeAtend.Text = nifCliente.NomePessoa;
                            textBox_moradaAtend.Text = nifCliente.MoradaPessoa;
                            textBox_nifAtend.Text = nifCliente.NumFiscCliente;
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor de pesquisa");
                }
            }
            else
            {
                MessageBox.Show("Campo válido apenas para Clientes já registados");
            }
        }
        private void limparTextBoxes()
        {
            textBox_pesquisa.Clear();
            textBox_nomeAtend.Clear();
            textBox_moradaAtend.Clear();
            textBox_nifAtend.Clear();
        }
        private void radioButton_novoCliente_CheckedChanged(object sender, EventArgs e)
        {
            // vai limpar os dados ao trocar de butão de seleção
            if (radioButton_novoCliente.Checked == true)
            {
                limparTextBoxes();
                textBox_nomeAtend.ReadOnly = false;
                textBox_moradaAtend.ReadOnly = false;
                textBox_nifAtend.ReadOnly = false;
            }
            else
            {
                limparTextBoxes();
                textBox_nomeAtend.ReadOnly = true;
                textBox_moradaAtend.ReadOnly = true;
                textBox_nifAtend.ReadOnly = true;
            }
        }

        private void radioButton_anonimo_CheckedChanged(object sender, EventArgs e)
        {
            // vai limpar os dados ao trocar de butão de seleção
            if (radioButton_anonimo.Checked == true)
            {
                limparTextBoxes();
                textBox_nomeAtend.Text = "Anonimo";
            }
            else
            {
                limparTextBoxes();
            }
        }

        private void button_criarBilhete_Click(object sender, EventArgs e)
        {
            if (listBox_lugaresSelecionados.Items.Count > 0 )
            {
                if(radioButton_anonimo.Checked == false && radioButton_cliente.Checked == false && radioButton_novoCliente.Checked == false)
                {
                    MessageBox.Show("Selecione o tipo de cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                }

            }

            else
            {
                MessageBox.Show("Selecione Primeiro os Lugares pretendidos para criar Bilhete");
            }

        }

        private void radioButton_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_cliente.Checked == true)
            {
                limparTextBoxes();
                buttonPesquisarNif.Visible = true;
                textBox_pesquisa.Visible = true;
            }
            else
            {
                limparTextBoxes();
                buttonPesquisarNif.Visible = false;
                textBox_pesquisa.Visible = false;
            }
        }
    }
}
