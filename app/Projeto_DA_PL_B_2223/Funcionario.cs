using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string NomeFuncionario { get; set; }
        public string MoradaFuncionario { get; set; }
        public string SalarioFuncionario { get; set; }
        public string TipoFuncionario { get; set; }

        public Funcionario(string nomeFuncionario, string moradaFuncionario, string salarioFuncionario, string tipoFuncionario)
        {
            NomeFuncionario = nomeFuncionario;
            MoradaFuncionario = moradaFuncionario;
            SalarioFuncionario = salarioFuncionario;
            TipoFuncionario = tipoFuncionario;

        }
       
        public override string ToString()
        {

            return "NOME:" + NomeFuncionario + "  MORADA: " + MoradaFuncionario + "  SALÁRIO: " + SalarioFuncionario + "€   FUNÇÃO: " + TipoFuncionario;
        }
    }
}
