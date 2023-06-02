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
        public string Filme { get; }
        public string Sala { get; }
        public double Preco { get; }
        public DateTime Data { get; }
        public DateTime Hora { get; }
        public List<Filme> Filmes { get; }
        public List<Sala> Salas { get; }
        public List<Sessao> Sessoes { get; }
        
        public Sessao()
        { 

        }

        public Sessao(string filme, string sala, double preco, DateTime data, DateTime hora)
        {
            Filme = filme;
            Sala = sala;
            Preco = preco;
            Data = data;
            Hora = hora;
            Filmes = new List<Filme>(); 
            Salas = new List<Sala>();
            Sessoes = new List<Sessao>();
        }


        public override string ToString()
        {
            return $"Filme: {Filme}, Sala: {Sala}, Preço: {Preco} , Dia: {Data} , Hora: {Hora} ";
        }
    }
}
