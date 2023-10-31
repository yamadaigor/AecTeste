using AeC_Teste.Business.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeC_Teste.Data.Data
{
    public class AecDbContext : DbContext
    {
        public AecDbContext(DbContextOptions options) : base(options)
        {

        }
        // DbSets
        public DbSet<LogErro> LogErros { get; set; }
        public DbSet<PrevisaoTempoAeroporto> PrevisaoTempoAeroporto { get; set; }
        public DbSet<PrevisaoTempoCidade> PrevisaoTempoCidade { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // se o  campo string (varchar) não for configurado, seta o tamanho padrão para 100
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                        .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                                                        property.SetColumnType("varchar(100)");

            // mapeia todas as classes que herdam de EntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AecDbContext).Assembly);
        }
    }
}
