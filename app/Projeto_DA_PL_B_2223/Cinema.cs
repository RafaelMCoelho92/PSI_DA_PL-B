using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    internal class Cinema
    {
        public string NomeCinema { get; }
        public string MoradaCinema { get; }
        public string EmailCinema { get; }

        public Cinema(string nomeCinema, string moradaCinema, string emailCinema)
        {
            NomeCinema = nomeCinema;
            MoradaCinema = moradaCinema;
            EmailCinema = emailCinema;
        }

        
    }
}
