using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wikipages.Models
{
    public class WikipagesContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Wikipages;integrated security=True");
        }
    }
}
