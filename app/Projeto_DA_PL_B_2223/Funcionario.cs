using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    internal class Funcionario
    {
        public string NomeFuncionario { get; }
        public string MoradaFuncionario { get; }
        public string SalarioFuncionario { get; }

        public Funcionario(string nomeFuncionario, string moradaFuncionario, string salarioFuncionrio)
        {
            NomeFuncionario = nomeFuncionario;
            MoradaFuncionario = moradaFuncionario;
            SalarioFuncionario = salarioFuncionrio;
        }
    }
}
