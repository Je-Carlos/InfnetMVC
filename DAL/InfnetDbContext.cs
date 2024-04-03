using InfnetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InfnetMVC.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.ToTable("Funcionarios");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.DepartamentoId);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamentos");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .IsRequired();
            });
        }
    }
  }


