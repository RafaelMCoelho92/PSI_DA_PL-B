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
        public List<Filme> Filmes { get; }
        public List<Sala> Salas { get; }
        public double Preco { get; set; }
        public DateTime DataHora { get; set; }
        public string Filme { get; set; }
        public string Sala { get; set; }

        public Sessao(double preco, DateTime datahora)
        {
            Preco = preco;
            DataHora = datahora;
            Filmes = new List<Filme>(); 
            Salas = new List<Sala>();
        }

        public Sessao(string filme, string sala)
        {
            Filme = filme;
            Sala = sala;
        }

        public void AddSessao(Filme filme, Sala sala)
        {
            Filmes.Add(filme);
            Salas.Add(sala);
        }

        public override string ToString()
        {
            return $"Filme: {Filmes}, Sala: {Salas}";
        }
    }
}
