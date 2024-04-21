using Microsoft.EntityFrameworkCore;
using ConsoleLocaVeiculos;
using ConsoleLocaVeiculos.Migrations;

namespace ConsoleLocaVeiculos.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LocaVeiculos;Trusted_Connection=True;TrustServerCertificate=True");

        }

    }
}