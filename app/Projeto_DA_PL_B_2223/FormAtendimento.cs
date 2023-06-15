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
        }

        public FormAtendimento(FormPrincipal formPrincipal) : this()
        {
            this.formPrincipal = formPrincipal;

        }



        public int getFilas(int Id)
        {
            var db = new ApplicationContext();
            var sessao = db.Sessoes.Find(Id); // procura a sessao pelo id recebido
            int idsala = sessao.idSala;  // ve qual o id da sala
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
        public void limparRadioButton()
        {
            radioButton_anonimo.Checked = false ;
            radioButton_cliente.Checked = false;
            radioButton_novoCliente.Checked = false;
        }
        public void limparSelecao()
        {
            limparTextBoxes();
            limparRadioButton();
            listBox_lugaresSelecionados.Items.Clear();
            double zero = 0;
            textBox_valorBilhete.Text = zero.ToString();


        }
        public string getNomeSala(int Id)
        {
            var db = new ApplicationContext();
            var sala = db.Salas.Find(Id);
            string nomeSala = "Nome da Sala: " + sala.nomeSala;

            return nomeSala;
        }

        public void setConfigSala(int id)
        {
            int filas = getFilas(id);
            int colunas = getColunas(id);
            string nomeSala = getNomeSala(id);
            tableLayoutPanelEscolherLugar.SuspendLayout();
            limparSelecao();
            tableLayoutPanelEscolherLugar.Controls.Clear();
            tableLayoutPanelEscolherLugar.RowCount = filas;
            tableLayoutPanelEscolherLugar.ColumnCount = colunas;
            labelNomeSala.Text = nomeSala;
            idsessao = id;


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Button button = new LugarButton(i, j);
                    button.Size = new Size(50, 25);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    button.BackColor = Color.Green;
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
                double valor = double.Parse(textBox_valorBilhete.Text);
                var sessao = db.Sessoes.Find(idsessao);
                valor += sessao.Preco;
                textBox_valorBilhete.Text = valor.ToString();
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
                            MessageBox.Show("Cliente não encontrado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor de pesquisa", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo válido apenas para Clientes já registados", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                textBox_moradaAtend.Text = "Anonimo";
                textBox_nifAtend.Text = "999999999";
            }
            else
            {
                limparTextBoxes();
            }
        }

        private void button_criarBilhete_Click(object sender, EventArgs e)
        {
            if (listBox_lugaresSelecionados.Items.Count > 0)
            {
                if (radioButton_anonimo.Checked == false && radioButton_cliente.Checked == false && radioButton_novoCliente.Checked == false)
                {
                    MessageBox.Show("Selecione o tipo de cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    if (radioButton_cliente.Checked == true)
                    {
                        if (textBox_nomeAtend.Text == "" || textBox_moradaAtend.Text == "" || textBox_nifAtend.Text == "")
                        {
                            MessageBox.Show("Pesquise por um cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {   // REVER PARA PESQUISAR E ATUALIZAR OS BILHETES COMPRADOS E O VALOR TOTAL

                            string valorPesquisa = textBox_pesquisa.Text;

                            if (!string.IsNullOrEmpty(valorPesquisa))
                            {
                                using (var db = new ApplicationContext())
                                {
                                    // Realiza a consulta no banco de dados
                                    var nifCliente = db.Pessoas.OfType<Cliente>().FirstOrDefault(p => p.NumFiscCliente == valorPesquisa);
                                    if (nifCliente == null)
                                    {
                                        MessageBox.Show("Cliente não encontrado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        nifCliente.totalBilhetes += listBox_lugaresSelecionados.Items.Count;
                                        nifCliente.valorTotal += double.Parse(textBox_valorBilhete.Text);
                                        db.Pessoas.AddOrUpdate(nifCliente);
                                        db.SaveChanges();
                                        limparSelecao();
                                    }
                                    /*double nif = double.Parse(textBox_pesquisa.Text);
                                    Cliente cliente = Cliente(textBox_pesquisa.Text); //db.Pessoas.OfType<Cliente>();
                                    var atualizarCliente = db.Pessoas.Find(cliente.NumFiscCliente);*/



                                }
                            }
                        }
                    }
                    else if (radioButton_novoCliente.Checked == true)
                    {
                        if (textBox_nomeAtend.Text == "")
                        {
                            MessageBox.Show("Insira o nome do novo cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (textBox_moradaAtend.Text == "")
                        {
                            MessageBox.Show("Insira a morada do novo cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (textBox_nifAtend.Text != "")
                        {
                            try
                            {
                                string nifNovoCliente = textBox_nifAtend.Text;
                                double contribuinte = 0;
                                // FAZ O PARSE DE STRING PARA DOUBLE - APENAS PERMITE A INSERÇÃO DE NUMEROS
                                contribuinte = double.Parse(nifNovoCliente);

                                if (contribuinte < 100000000 || contribuinte >= 700000000)
                                {
                                    MessageBox.Show("O número fiscal a inserir deve ser válido, e deve ser entre 100000000 e 700000000", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                else
                                {
                                    var db = new ApplicationContext();
                                    Cliente novocliente = new Cliente(textBox_nomeAtend.Text, textBox_moradaAtend.Text, textBox_nifAtend.Text, totalbilhetes:0, valortotal:0);//add bilhete e total a 0 para passar para o construtor da classe
                                    bool existeCliente = db.Pessoas.OfType<Cliente>().Any(p => p.NumFiscCliente == novocliente.NumFiscCliente);
                                    if (existeCliente)
                                    {
                                        MessageBox.Show("Cliente com numero fiscal ja existente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }


                                    // Cliente novocliente = new Cliente(textBox_nomeAtend.Text, textBox_moradaAtend.Text, textBox_nifAtend.Text);
                                    // using (var db = new ApplicationContext())
                                    novocliente.totalBilhetes += listBox_lugaresSelecionados.Items.Count;
                                    novocliente.valorTotal += double.Parse(textBox_valorBilhete.Text);
                                    db.Pessoas.Add(novocliente);
                                    db.SaveChanges();
                                    limparSelecao();

                                    MessageBox.Show("Cliente criado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Apenas devem constar números neste campo", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insira o numero fiscal do novo cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else if (radioButton_anonimo.Checked == true)
                    {
                        if (textBox_nomeAtend.Text != "Anonimo" || textBox_moradaAtend.Text != "Anonimo" || textBox_nifAtend.Text != "999999999")
                        {
                            MessageBox.Show("Nao insira dados para a compra do bilhete!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Selecione Primeiro os Lugares pretendidos para criar Bilhete", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
