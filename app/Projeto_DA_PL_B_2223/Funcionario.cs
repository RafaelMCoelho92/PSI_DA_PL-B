using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Funcionario:Pessoa
    {
        [Key]

        public string SalarioFuncionario { get; set; }
        public string TipoFuncionario { get; set; }

        public Funcionario(string nomePessoa, string moradaPessoa, string salarioFuncionario,  string tipoFuncionario):base(nomePessoa,moradaPessoa)
        {
            
            SalarioFuncionario = salarioFuncionario;
            TipoFuncionario = tipoFuncionario;

        }

        public Funcionario()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        public override string ToString()
        {
            return "NOME: " + NomePessoa + "  MORADA: " + MoradaPessoa + "  FUNÇÃO: " + TipoFuncionario + " SALARIO: " + SalarioFuncionario;
        }
    }
}
