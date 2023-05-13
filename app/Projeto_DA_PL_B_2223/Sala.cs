using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    internal class Sala
    {
        public string nomeSala { get; }
        // public List<LinhaColuna> LinhasColunas { get; }

        public Sala(string nomeSala)
        {
            this.nomeSala = nomeSala;
            //Linhas = new List<LinhaColuna>();
        }

        public override string ToString()
        {
            return nomeSala + " ";
        }

    }
    



}
