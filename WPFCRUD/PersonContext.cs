using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCRUD
{
    public class PersonContext:DbContext
    {
        public DbSet<Person> Persons { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MssqlLocaldb;database=Emberek;Trusted_Connection=true");
        }
    }
}
