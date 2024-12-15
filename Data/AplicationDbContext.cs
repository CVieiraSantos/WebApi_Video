using Microsoft.EntityFrameworkCore;
using WebApi_Video.Models;

namespace WebApi_Video.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
    }
}
