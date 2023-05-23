using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Sala
    {
        [Key]
        public int Id { get; set; }
        public string nomeSala { get; set; }
        public double Fila { get; set; }
        public double Coluna { get; set; }
        public double Lugares { get; set; }

        //Constructor
        public Sala(string nomeSala)
        {
            this.nomeSala = nomeSala;
        }

        public Sala()
        {

        }


        // METODO ALTERAR PARA EDITAR O VALOR DAS FILAS E COLUNAS DE UMA SALA
        public string Alterar(double valorfila, double valorcoluna, double totalLugares)
        {
            Fila = valorfila;
            Coluna = valorcoluna;
            Lugares = totalLugares;
            string representacao = nomeSala + " Filas: " + Fila + " Colunas: " + Coluna + " Total Lugares: " + Lugares;
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
            return nomeSala + " Filas: " + Fila + " Colunas: " + Coluna + " Total Lugares: " + Lugares; 
        }

        
    }
}
