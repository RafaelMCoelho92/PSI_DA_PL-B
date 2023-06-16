using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]

    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string NomePessoa { get; set; }
        public string MoradaPessoa { get; set; }

        public Pessoa(string nomePessoa, string moradaPessoa)
        {
            NomePessoa = nomePessoa;
            MoradaPessoa = moradaPessoa;
        }

        public Pessoa()
        {
            // Construtor vazio necessário para o Entity Framework
        }
    }
}
