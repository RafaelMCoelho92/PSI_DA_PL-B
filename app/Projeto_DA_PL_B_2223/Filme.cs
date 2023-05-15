using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    internal class Filme
    {
        public string nomeFilme { get; set; }
        public string categoriaFilme { get; set; }
        public string estadoFilme { get; set; }

        public Filme(string nomeFilme, string categoriaFilme, string estadoFilme)
        {
            this.nomeFilme = nomeFilme;
            this.categoriaFilme = categoriaFilme;
            this.estadoFilme = estadoFilme;
        }

        // OVERRIDE PARA DIZER O QUE VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return "Nome do Filme: " + nomeFilme + " Categoria: " + categoriaFilme + " Estado: " + estadoFilme;
        }
    }
}
