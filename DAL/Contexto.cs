using System;
using Microsoft.EntityFrameworkCore;
using Examen_Parcial_1.Models;

namespace Examen_Parcial_1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<NCFAutorizados> NCFAutorizados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data\Examen.db");
        }
    }
}