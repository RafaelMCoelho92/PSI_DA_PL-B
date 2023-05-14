using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    internal class Funcionario
    {
        private double salarioFuncionario;

        public string NomeFuncionario { get; }
        public string MoradaFuncionario { get; }
        public string SalarioFuncionario { get; }
        public string TipoFuncionario { get; }

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
