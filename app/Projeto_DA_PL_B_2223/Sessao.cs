using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Sessao
    {
        [Key]
        public int Id { get; set; }
        public double Preco { get; set; }
        public DateTime DataHora { get; set; }
        public Filme Filme { get; }
        public Sala Sala { get; }

        public Sessao()
        {
        }

        public Sessao(double preco, DateTime dataHora, Filme filme, Sala sala)
        {
            Preco = preco;
            DataHora = dataHora;
            Filme = filme;
            Sala = sala;
        }
    }
}
