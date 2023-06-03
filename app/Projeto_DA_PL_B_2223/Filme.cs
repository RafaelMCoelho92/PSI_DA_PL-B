using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        public string nomeFilme { get; set; }
        public string categoriaFilme { get; set; }
        public string estadoFilme { get; set; }
        public string Duracao { get; set; }

        public Filme(string nomeFilme, string categoriaFilme, string estadoFilme, string hora)
        {
            this.nomeFilme = nomeFilme;
            this.categoriaFilme = categoriaFilme;
            this.estadoFilme = estadoFilme;
            this.Duracao = hora;
            // Hora = hora ---- porquê o this? dá na mesma sem this
        }

        public Filme() // construtor vazio para o entity framework 
        {

        }



        // OVERRIDE PARA DIZER O QUE VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return "Nome do Filme: " + nomeFilme + " Categoria: " + categoriaFilme + " Estado: " + estadoFilme + " Hora: " + Duracao;
        }
    }
}
