using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compney.Models
{
    class Context:DbContext
    {
        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivangi\Documents\CompneyDb.mdf;Integrated Security=True;Connect Timeout=30");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Compneys> Compneys { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Leaves> Leaves { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Admins> Admins { get; set; }
    }
}
