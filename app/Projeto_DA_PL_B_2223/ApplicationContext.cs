using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Bilhete> Bilhetes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; } 
    }
}
