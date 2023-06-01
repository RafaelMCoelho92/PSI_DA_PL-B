﻿using System;
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
    public partial class FormSala : Form
    {
        private FormPrincipal formPrincipal;

        public FormSala()
        {
            InitializeComponent();
            this.CenterToScreen();
            atualizarDadosAoEntrar();
        }
        public FormSala(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }
        //metodo para atualizar os dados ao carregar o formulario da sala
        private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var salas = db.Salas.ToList();
                foreach (var sala in salas) //correr as salas para os adicionar à listBox 
                {
                    listBoxSalas.Items.Add(sala); // Escrever o que está na toString do (class) Sala 
                }
            }
        }
        // Valida os dados inseridos nas textbox
        public bool validarDadosSalas()
        {
            // VARIAVEIS PARA UTILIZAR NO PARSE
            double valorFila = 0;
            double valorColuna = 0;


            try
            {   // FAZER O PARSE-> OU SEJA PASSAR DE STRING PARA DOUBLE
                string filas = textBoxFilas.Text;
                string colunas = textBoxColunas.Text;
                valorFila = double.Parse(filas);
                valorColuna = double.Parse(colunas);
                // CASO VALOR SEJA MENOR OU IGUAL A ZERO-> MENSAGEM DE ERRO
                if (valorFila <= 0 || valorColuna <= 0)
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser superior a 0 (zero)!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // CASO VALOR SEJA MAIOR QUE 20 -> MENSAGEM DE ERRO
                if (valorFila > 20 || valorColuna > 20)
                {
                    MessageBox.Show("As Filas e as Colunas tem de ser inferior a 20!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            // CASO NAO SEJA NUMERO 
            catch (Exception)
            {
                MessageBox.Show("Valor Invalido, insira um valor entre 1 e 20!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string nomeSala = textBoxNomeSala.Text;
            // se os n forem validos vai retornar false
            if (nomeSala.Length == 0)
            {
                MessageBox.Show("O nome da sala não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            double fila;
            //VALIDA QUE AS FILAS NAO ESTAO COM LETRAS
            if (!double.TryParse(textBoxFilas.Text, out fila))
            {
                MessageBox.Show("O numero de filas deve ser numérico");
                return false;
            }
            double coluna;
            //VALIDA QUE AS COLUNAS NAO ESTA COM LETRAS
            if (!double.TryParse(textBoxColunas.Text, out coluna))
            {
                MessageBox.Show("O numero de colunas deve ser numérico");
                return false;
            }
            else // se for tudo valido retorna true
            {
                return true;
            }
        }

        // ADICIONA UMA SALA NA LIST BOX
        private void buttonAdicionarSala_Click(object sender, EventArgs e)
        {
            // chama a funcao para validar os dados
            // vai ver se cumpre a todas as condicoes , caso nao cumpra qualquer condiçao vai saltar fora
            if (!validarDadosSalas())
            {
                return;
            }// caso cumpra vai continuar

            //guarda os valores inseridos nas variaveis
            string nomeSala = textBoxNomeSala.Text;
            string filas = textBoxFilas.Text;// faz a conversao de texto para double
            string colunas = textBoxColunas.Text;// faz a conversao de texto para double
            try
            {

                Sala sala = new Sala(nomeSala, filas, colunas);
                textBoxNomeSala.Text = sala.nomeSala;
                textBoxFilas.Text = sala.Fila.ToString();// neste leva o tostring pq esta a ser convertido para double
                textBoxColunas.Text = sala.Coluna.ToString();
            }
            catch
            {
                // caso haja algum erro
                MessageBox.Show("Erro ao criar sala");
            }
            if (listBoxSalas.SelectedIndex != -1) // se tiver uma sala selecionada, altera os dados
            {
                Sala salaSelecionada = (Sala)listBoxSalas.SelectedItem;
                // altera dos dados da sala selecionada
                salaSelecionada.nomeSala = textBoxNomeSala.Text;
                salaSelecionada.Fila = textBoxFilas.Text;
                salaSelecionada.Coluna = textBoxColunas.Text;
                // Atualizar a exibição do funcionário na ListBox
                int editarsala = listBoxSalas.SelectedIndex;
                listBoxSalas.Items[editarsala] = salaSelecionada;

                using (var db = new ApplicationContext())
                {   //faz update do funcionario
                    db.Salas.AddOrUpdate(salaSelecionada);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Sala novaSala = new Sala(textBoxNomeSala.Text, textBoxFilas.Text, textBoxColunas.Text);

                listBoxSalas.Items.Add(novaSala); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria nova sala
                    db.Salas.Add(novaSala);
                    db.SaveChanges();
                }
            }
        }

        private void FormSala_Load(object sender, EventArgs e)
        {
            listBoxSalas.ClearSelected();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxSalas.ClearSelected();
        }

    }
}
