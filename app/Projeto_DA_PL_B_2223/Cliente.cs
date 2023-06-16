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
        public int totalBilhetes { get; set; }
        public double valorTotal { get; set; }

        public Cliente(string nomePessoa, string moradaPessoa, string numFiscCliente, int totalbilhetes, double valortotal):base(nomePessoa, moradaPessoa)
        {
            NumFiscCliente = numFiscCliente;
            totalBilhetes = totalbilhetes;
            valorTotal = valortotal;
        }

        public Cliente()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        public override string ToString()
        {
            return "NOME: " + NomePessoa + " |  MORADA: " + MoradaPessoa + " | NIF: " + NumFiscCliente;
        }
    }
}
