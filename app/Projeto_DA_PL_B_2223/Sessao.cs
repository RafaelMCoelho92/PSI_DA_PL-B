using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
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
        public List<Filme> Filmes { get; }
        public List<Sala> Salas { get; }
        public List<Sessao> Sessoes { get; }
        public double Preco { get; set; }
        public DateTime DataHora { get; set; }
        public string Filme { get; set; }
        public string Sala { get; set; }

        public Sessao()
        { 

        }

        public Sessao(double preco, DateTime datahora)
        {
            Preco = preco;
            DataHora = datahora;
            Filmes = new List<Filme>(); 
            Salas = new List<Sala>();
            Sessoes = new List<Sessao>();
        }

        public Sessao(string filme, string sala)
        {
            Filme = filme;
            Sala = sala;
        }

        public override string ToString()
        {
            return $"Filme: {Filme}, Sala: {Sala}";
        }
    }
}
