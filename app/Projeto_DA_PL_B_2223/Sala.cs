using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    internal class Sala
    {
        public string nomeSala { get; set; }
        public double Fila { get; set; }
        public double Coluna { get; set; }

        //Constructor
        public Sala(string nomeSala)
        {
            this.nomeSala = nomeSala;
            Fila = 0;
            Coluna = 0;
        }
        // METODO ALTERAR PARA EDITAR O VALOR DAS FILAS E COLUNAS DE UMA SALA
        public string Alterar(double valorfila, double valorcoluna)
        {
            Fila = valorfila;
            Coluna = valorcoluna;
            string representacao = nomeSala + " Fila: " + Fila + " Coluna: " + Coluna;
            return representacao;

        }
        // METODO PARA APAGAR UMA SALA
        public void RemoverSala(Sala sala)
        {
            // APAGAR 
        }

        // OVERRIDE PARA DIZER COMO VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return nomeSala + " Fila: " + Fila + " Coluna: " + Coluna; 
        }

    }
    



}
