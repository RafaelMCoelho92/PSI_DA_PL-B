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
        public string Filme { get; set; }
        public string Sala { get; set; }
        public double Preco { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public List<Filme> Filmes { get; set; }
        public List<Sala> Salas { get; set; }
        public List<Sessao> Sessoes { get; set; }
        
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
            return $"Filme: {Filme} Sala: {Sala} Preço: {Preco}  Dia: {Data.ToString("dd/MM/yyyy")}  Hora: {Hora.ToString("HH:mm")} ";
        }
    }
}
