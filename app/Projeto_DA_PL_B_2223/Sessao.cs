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
        public int idFilme { get; set; }
        public int idSala { get; set; }
        public double Preco { get; set; }
        public string Data { get; set; }
        public TimeSpan Hora { get; set; }
        
        public Sessao()
        { 

        }

        public Sessao(int idfilme, int idsala, double preco, string data, TimeSpan hora)
        {
            idFilme = idfilme;
            idSala = idsala;
            Preco = preco;
            Data = data;
            Hora = hora;
        }

        public override string ToString()
        {
            var db = new ApplicationContext();
            var nomefilme = db.Filmes.Find(idFilme);
            var filme = nomefilme.nomeFilme;
            var nomesala = db.Salas.Find(idSala);
            var sala = nomesala.nomeSala;
            
            return $"Filme: {filme} | Sala: {sala} | Preço: {Preco} € | Dia: {Data}  | Hora: {Hora}  | Duração:  {nomefilme.Duracao}";
        }
    }
}
