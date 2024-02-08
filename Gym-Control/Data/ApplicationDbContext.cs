using Microsoft.EntityFrameworkCore;
using Models;

namespace Gym_Control.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Outros DbSets e configurações, se necessário

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuração da string de conexão
            optionsBuilder.UseMySql("DefaultConnection", new MySqlServerVersion(new Version(7, 0, 0)));
        }
    }
}

