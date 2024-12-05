using Microsoft.EntityFrameworkCore;
using ProjectISO.Models;

namespace ProjectISO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Activo> Activo { get; set; }
        public DbSet<TipoDeActivo> TipoDeActivos {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuracion de Entidades
            modelBuilder.Entity<Departamento>()
                .HasIndex(p => p.Id)
                .IsUnique();
            modelBuilder.Entity<Activo>()
                .HasIndex(p => p.Id)
                .IsUnique();
            modelBuilder.Entity<TipoDeActivo>()
                .HasIndex(p => p.Id)
                .IsUnique();
            modelBuilder.Entity<Empleado>()
                .HasIndex(p => p.Id)
                .IsUnique();


            // Configuracion de relacion entre entidades
            modelBuilder.Entity<Empleado>()
                .HasOne(p => p.Departamento)
                .WithMany(p => p.Empleados)
                .HasForeignKey(p => p.DepartamentoId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Activo>()
                .HasOne(p => p.TipoDeActivo)
                .WithOne(p => p.Activo)
                .HasForeignKey<TipoDeActivo>(p => p.ActivoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Activo>()
                .HasOne(p => p.Departamento)
                .WithMany(p => p.Activos)
                .HasForeignKey(p => p.DepartamentoId)
                .OnDelete(DeleteBehavior.Cascade);
                /*
                 
                 modelBuilder.Entity<Blog>()
        .HasOne(e => e.Header)
        .WithOne(e => e.Blog)
        .HasForeignKey<BlogHeader>(e => e.BlogId)
        .IsRequired();
                 */



            
        }
    }
}
