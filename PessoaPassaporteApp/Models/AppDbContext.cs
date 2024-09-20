using Microsoft.EntityFrameworkCore;

namespace PessoaPassaporteApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Passaporte> Passaportes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasOne(p => p.Passaporte)
                .WithOne(p => p.Pessoa)
                .HasForeignKey<Passaporte>(p => p.PessoaId);
        }
    }
}
