using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Cliente:Pessoa
    {
        [Key]

        public string NumFiscCliente { get; set; }

        public Cliente(string numFiscCliente)
        {
            NumFiscCliente = numFiscCliente;
        }
    }
}
