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
    public partial class FormFuncionarios : Form
    {
        private FormPrincipal formPrincipal;
        public FormFuncionarios()
        {
            InitializeComponent();
            this.CenterToScreen();

            atualizarDadosAoEntrar();
        }

        public FormFuncionarios(FormPrincipal formPrincipal) : this() // recebemos no construtor deste form o form principal e podemos utilizar os metodos do principal
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
                var funcionarios = db.Pessoas.OfType<Funcionario>();
                foreach (var funcionario in funcionarios) //correr os funcionarios para os adicionar à listBox 
                {
                    listBoxFuncionarios.Items.Add(funcionario); 
                }
            }

        }
        public bool validarDadosFuncionario()
        {
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            // retorna false caso nao cumpra qualquer condicao
            // retorna true caso cumpra a todas
            string nomeFuncionario = textBoxNomeFuncionario.Text;
            if (nomeFuncionario.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio");
                return false;
            }
            string moradaFuncionario = textBoxMoradaFuncionario.Text;
            if (moradaFuncionario.Length == 0)
            {
                MessageBox.Show("A morada não pode ser vazio");
                return false;
            }

            double salarioFuncionario;
            if (!double.TryParse(textBoxSalarioFuncionario.Text, out salarioFuncionario))
            {
                MessageBox.Show("O valor do salário deve ser numérico");
                return false;
            }


            string tipoFuncionario = comboBoxFuncaoFuncionario.Text;
            if (tipoFuncionario.Length == 0)
            {
                MessageBox.Show("É necessário atribuir uma função");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonGuardarFuncionario_Click(object sender, EventArgs e)
        {
            // vai ver se cumpre a todas as condicoes , caso nao cumpra qualquer condiçao vai saltar fora
            if (!validarDadosFuncionario())
            {
                return;
            }// caso cumpra vai continuar

            //guarda os valores inseridos nas variaveis
            string nomeFuncionario = textBoxNomeFuncionario.Text;
            string moradaFuncionario = textBoxMoradaFuncionario.Text;
            string tipoFuncionario = comboBoxFuncaoFuncionario.Text;
            double salarioFuncionario = double.Parse(textBoxSalarioFuncionario.Text);// faz a conversao de texto para double

            try
            {   // manda para o construtor faz a instancia
                Funcionario funcionario = new Funcionario(nomeFuncionario, moradaFuncionario, salarioFuncionario.ToString(), tipoFuncionario);
                textBoxMoradaFuncionario.Text = funcionario.MoradaPessoa;
                textBoxNomeFuncionario.Text = funcionario.NomePessoa;
                textBoxSalarioFuncionario.Text = funcionario.SalarioFuncionario.ToString();
                comboBoxFuncaoFuncionario.Text = funcionario.TipoFuncionario;
            }
            catch (Exception)
            {   // caso haja algum erro
                MessageBox.Show("Erro ao criar funcionário");
            }


            if (listBoxFuncionarios.SelectedIndex != -1) // se tiver um funcionario selecionado, altera os dados
            {
                Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem;
                // altera dos dados do funcionario selecionado
                funcionarioSelecionado.NomePessoa = textBoxNomeFuncionario.Text;
                funcionarioSelecionado.MoradaPessoa = textBoxMoradaFuncionario.Text;
                funcionarioSelecionado.TipoFuncionario = comboBoxFuncaoFuncionario.Text;
                funcionarioSelecionado.SalarioFuncionario = textBoxSalarioFuncionario.Text;
                // Atualizar a exibição do funcionário na ListBox
                int editarfuncionario = listBoxFuncionarios.SelectedIndex;
                listBoxFuncionarios.Items[editarfuncionario] = funcionarioSelecionado;

                using (var db = new ApplicationContext())
                {   //faz update do funcionario
                    db.Pessoas.AddOrUpdate(funcionarioSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Funcionario novofuncionario = new Funcionario(textBoxNomeFuncionario.Text, textBoxMoradaFuncionario.Text, textBoxSalarioFuncionario.Text, comboBoxFuncaoFuncionario.Text);

                listBoxFuncionarios.Items.Add(novofuncionario); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria novo funcionario
                    db.Pessoas.Add(novofuncionario);
                    db.SaveChanges();
                }
            }

        }

        private void buttonApagarFuncionario_Click(object sender, EventArgs e)
        {
            int apagarFunc = listBoxFuncionarios.SelectedIndex;
            if (apagarFunc == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxFuncionarios.Items[apagarFunc] is Funcionario funcionario)
            {
                //se tiver funcionario selecionado
                // apaga da listbox
                listBoxFuncionarios.Items.Remove(funcionario);
                //apaga da base de dados
                var db = new ApplicationContext();
                var apagarfuncionario = db.Pessoas.Find(funcionario.Id); // buscar o id do funcionario q queremos apagar, se for pelo funcionario da barraca assim funciona
                if (apagarfuncionario != null) // so faz isso se tiver um funcionario
                {
                    db.Pessoas.Remove(apagarfuncionario); // remove funcionario pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        // METODO PARA APARECER O NOME DO FUNCIONARIO NA LABEL ONDE DIZ "FAÇA LOGIN"
        public void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherFunc = listBoxFuncionarios.SelectedIndex;
            if (escolherFunc != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    // mostrar na textBox os dados do funcionario selecionado                                                                                   
                    textBoxNomeFuncionario.Text = funcionarioSelecionado.NomePessoa;
                    textBoxMoradaFuncionario.Text = funcionarioSelecionado.MoradaPessoa;
                    comboBoxFuncaoFuncionario.Text = funcionarioSelecionado.TipoFuncionario;
                    textBoxSalarioFuncionario.Text = funcionarioSelecionado.SalarioFuncionario;
                }

            }
        }                                                      

        private void listBoxFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            //verificar que foi selecionado algo
            //caso tenha sido fazer o set no footer do menuprincipal
            int escolherFunc = listBoxFuncionarios.SelectedIndex;
            if (escolherFunc == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário");
                return; 
            }//

                // buscar o nome do funcionario selecionado
            if (listBoxFuncionarios.Items[escolherFunc] is Funcionario funcionario)
            {
                var db = new ApplicationContext();
                var nomefuncionario = db.Pessoas.Find(funcionario.Id); // buscar o id do funcionario q queremos mandar para o formprincipal
                if (nomefuncionario != null) // so faz isso se tiver um funcionario
                {
                        this.formPrincipal.setNomeFuncionario(nomefuncionario.Id);
                        this.Close();
                }
            }


        }

    }
}


