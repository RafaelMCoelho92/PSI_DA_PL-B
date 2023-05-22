﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    internal class Cliente
    {
        public string NomeCliente { get; set; } 
        public string MoradaCliente { get; set; }
        public string NumFiscCliente { get; set; }

        public Cliente(string nomeCliente, string moradaCliente, string numFiscCliente)
        {
            NomeCliente = nomeCliente;
            MoradaCliente = moradaCliente;
            NumFiscCliente = numFiscCliente;
        }
    }
}