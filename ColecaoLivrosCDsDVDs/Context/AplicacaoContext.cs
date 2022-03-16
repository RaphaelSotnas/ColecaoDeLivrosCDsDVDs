using ColecaoLivrosCDsDVDs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public class AplicacaoContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Item> Itens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ColecaoDB;Trusted_Connection=true;");
        }
    }
}
