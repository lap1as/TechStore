using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechStore
{

    public class TechStoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=sa;Password=6732158492;Encrypt=False");
        }
    }

}
