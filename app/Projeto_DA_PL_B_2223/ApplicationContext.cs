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
        
        
    }
}
