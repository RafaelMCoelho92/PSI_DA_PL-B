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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void buttonGuardarFuncionario_Click(object sender, EventArgs e)
        {
            
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            string nomeFuncionario = textBoxNomeFuncionario.Text;
            if (nomeFuncionario.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio");
                return;
            }
            string moradaFuncionario = textBoxMoradaFuncionario.Text;
            if (moradaFuncionario.Length == 0)
            {
                MessageBox.Show("A morada não pode ser vazio");
                return;
            }
            
            double salarioFuncionario;
            if (!double.TryParse(textBoxSalarioFuncionario.Text, out salarioFuncionario))
            {
                MessageBox.Show("O valor do salário deve ser numérico");
                return;
            }
            
            
            string tipoFuncionario = comboBoxFuncaoFuncionario.Text;
            if (tipoFuncionario.Length == 0)
            {
                MessageBox.Show("É necessário atribuir uma função");
                return;
            }

            try
            {
                Funcionario funcionario = new Funcionario(nomeFuncionario, moradaFuncionario, salarioFuncionario.ToString(), tipoFuncionario);
                textBoxMoradaFuncionario.Text = funcionario.MoradaPessoa;
                textBoxNomeFuncionario.Text = funcionario.NomePessoa;
                textBoxSalarioFuncionario.Text = funcionario.SalarioFuncionario.ToString();
                comboBoxFuncaoFuncionario.Text = funcionario.TipoFuncionario;

                listBoxFuncionarios.Items.Add(funcionario);

            }
            catch (Exception)
            {   // caso haja algum erro
                MessageBox.Show("Erro ao criar funcionário");
            }


        }

        private void buttonApagarFuncionario_Click(object sender, EventArgs e)
        {
            int apagarFunc = listBoxFuncionarios.SelectedIndex;
            if (apagarFunc == -1)
            {
                MessageBox.Show("Selecione um Funcionário");
                return;
            }
            
            if (listBoxFuncionarios.Items[apagarFunc] is Funcionario funcionario)
            {
                listBoxFuncionarios.Items.Remove(funcionario);
            }
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //formPrincipal.setNomeFuncionario(cinema.NomeCinema);
        }
    }
}
