using Microsoft.EntityFrameworkCore;
using ConsoleLocaVeiculos;
using ConsoleLocaVeiculos.Migrations;

    namespace ConsoleLocaVeiculos.Context
    {
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
            {
            }

            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Veiculo> Veiculo { get; set; }
            public DbSet<Reserva> Reserva { get; set; }
        }
    }

