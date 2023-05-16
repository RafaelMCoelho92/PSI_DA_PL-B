using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    [Serializable]
    public class Cinema
    {
        [Key]
        public int Id { get; set; } 
        public string NomeCinema { get; set; }
        public string MoradaCinema { get; set; }
        public string EmailCinema { get; set;  }

        public Cinema(string nomeCinema, string moradaCinema, string emailCinema)
        {
            NomeCinema = nomeCinema;
            MoradaCinema = moradaCinema;
            EmailCinema = emailCinema;
        }

        public Cinema()
        {

        }

        
    }
}
