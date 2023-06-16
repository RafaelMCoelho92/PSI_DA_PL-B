using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }

        public string[] Categorias = { "Comédia", "Sci-Fi","Terror","Romance","Acção","Thriller","Drama","Mistério","Crime","Aventura","Fantasia","Animação"  };

        public Categoria()
        {
            // construtor vazio para entity framework
        }

        public Categoria(string categoria, string estado)
        {
            this.categoria = categoria;
            this.estado = estado;
        }

        public override string ToString()
        {
            return "Categoria: " + categoria + " Estado: " + estado;
        }
    }


}
