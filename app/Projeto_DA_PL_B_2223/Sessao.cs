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
        //public double Preco { get; set; }
        //public DateTime DataHora { get; set; }
        //public Filme Filme { get; }
        //public Sala Sala { get; }
        public List<Filme> Filmes { get; set; }
        public List<Sala> Salas { get; set; }

        public Sessao(string filme, string sala)
        {
            Filmes = new List<Filme>(); 
            Salas = new List<Sala>();
        }

        /*public Sessao(List<Filme> filmes, List<Sala> salas)
        {
            Filmes = filmes;
            Salas = salas;
        }*/


        /*public Sessao(double preco, DateTime dataHora, Filme filme, Sala sala)
        {
            Preco = preco;
            DataHora = dataHora;
            Filme = filme;
            Sala = sala;
        }*/

        // MÉTODO PARA PROCURAR E RETORNAR OS FILMES DA BASE DE DADOS
        public List<Filme> FilmeList()
        {
            using (var db = new ApplicationContext())
            {
                return db.Filmes.ToList();
            }
        }

        // MÉTODO PARA PROCURAR E RETORNAR AS SALAS DA BASE DE DADOS
        public List<Sala> SalaList()
        {
            using (var db = new ApplicationContext())
            {
                return db.Salas.ToList();
            }
        }

        // MÉTODO PARA PROCURAR E RETORNAR AS SESSÕES DA BASE DE DADOS
        public List<Sessao> SessaoList()
        {
            using (var db = new ApplicationContext())
            {
                return db.Sessoes.ToList();
            }
        }

        public override string ToString()
        {
            return $"Filme: {Filmes}, Sala: {Salas}";
        }
    }
}
