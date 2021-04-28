using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ProjetoGabrielDDDMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjetoGabrielDDD;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=ProjetoGabrielDDDTest;Integrated Security=True");
        }
       

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        
    }
}

