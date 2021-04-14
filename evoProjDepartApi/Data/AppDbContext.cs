using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using evoProjDepartApi.Data;

namespace evoProjDepartApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .Property(p => p.Nome)
                    .HasMaxLength(30);

            modelBuilder.Entity<Departamento>()
               .Property(p => p.Sigla)
                   .HasMaxLength(5);

            modelBuilder.Entity<Departamento>()
                .HasData(
                    new Departamento { DepartamentoId = 1, Nome = "Recursos Humanos", Sigla = "RH" }
                );

            modelBuilder.Entity<Funcionario>()
                .Property(p => p.Nome)
                    .HasMaxLength(40);

            modelBuilder.Entity<Funcionario>()
                .Property(p => p.Rg)
                    .HasMaxLength(9);

            modelBuilder.Entity<Funcionario>()
                 .HasData(
                     new Funcionario { FuncionarioId = 1, Nome = "Naiara", Foto = "", Rg = "559678688", DepartamentoId = 1 }
                 );
        }

        public DbSet<evoProjDepartApi.Data.Funcionario> Funcionarios { get; set; }
    }
}
