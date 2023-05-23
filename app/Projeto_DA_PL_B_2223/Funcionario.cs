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

        public Funcionario( string salarioFuncionario,  string tipoFuncionario)
        {

            SalarioFuncionario = salarioFuncionario;
            TipoFuncionario = tipoFuncionario;

        }
       

    }
}
