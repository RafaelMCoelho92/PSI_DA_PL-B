﻿using System;
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
        public double Lugares { get; set; }
        public int Id_Cinema { get; set; }

        //Constructor
        public Sala(string nomeSala, string fila, string coluna, int id_Cinema)
        {
            this.nomeSala = nomeSala;
            this.Fila = fila;
            this.Coluna = coluna;
            this.Lugares = CalcularTotalLugares();
            this.Id_Cinema = id_Cinema;
        }

        public Sala()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        // OVERRIDE PARA DIZER COMO VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return nomeSala + " --> Filas: " + Fila + " / Colunas: " + Coluna + " --> Total Lugares: " + CalcularTotalLugares();
        }

        public int CalcularTotalLugares()
        {
            int filas = int.Parse(Fila);
            int colunas = int.Parse(Coluna);
            return filas * colunas;
        }
    }
}
