using Microsoft.EntityFrameworkCore;
using RunGym.API.Models;
using RunGym.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGym.API.Repositorios
{
    public class DatabaseService :DbContext
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfuguration(modelBuilder);
        }

        private void EntityConfuguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Usuarios>().HasKey(u => u.Id);
            modelBuilder.Entity<Usuarios>().Property(u => u.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuarios>().Property(u => u.Nombre).HasColumnName("Nombre");
        }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
    }
}
