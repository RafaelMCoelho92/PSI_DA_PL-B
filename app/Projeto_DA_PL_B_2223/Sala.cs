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
        public string Fila { get; set; }
        public string Coluna { get; set; }

        //Constructor
        
        public Sala(string nomeSala, string fila, string coluna)
        {
            this.nomeSala = nomeSala;
            this.Fila = fila;
            this.Coluna = coluna;
        }

        public Sala()
        {
            // Construtor vazio necessário para o Entity Framework

        }



        // METODO PARA APAGAR UMA SALA
        public void RemoverSala(Sala sala)
        {
            // APAGAR 
        }

        // OVERRIDE PARA DIZER COMO VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return nomeSala + " Filas: " + Fila + " Colunas: " + Coluna; 
        }

        
    }
}
