using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleLocaVeiculos
{
    internal class Program
    {
        public class Cliente
        {
            // Declarando a PK de Cliente
            [Key]
            public int IdCliente { get; set; }
            public string? Nome { get; set; }
            public string? Telefone { get; set; }
            public string? Endereco { get; set; }
            public string? Email { get; set; }
            public Boolean EhNovoCliente { get; set; } //Para saber se o cliente já é antigo na loja ou não, visando futuras promoções
            public int QuantLocados { get; set; } //Saber quantos veiculos o cliente já alugou

            public ICollection<Reserva> Reservas { get; set; }

        }

        public class Reserva
        {
            //Declarando a PK de Reserva
            [Key]
            public int IdReserva { get; set; }
            //FK de Reserva será a PK de Cliente
            public int IdCliente { get; set; }
            [ForeignKey("IdCliente")]
            //FK de Reserva será a PK de Veiculo
            public int IdVeiculo { get; set; }
            [ForeignKey("IdVeiculo")]

            public DateTime DataComeco { get; set; }
            public DateTime DataFim { get; set; }
            public Boolean VaiEstender { get; set; } //Caso o cliente queira mais tempo da locação do que estipulado no contrato
            public int QuantoTempo { get; set; } //Quanto tempo o cliente ficará caso estenda o contrato
            public int ValorTotal { get; set; } //O valor total levará em consideração se o cliente estendeu o contrato ou não
        }

        public class Veiculo
        {
            //Declarando a PK de Veiculo
            [Key]
            public int IDVeiculo { get; set; }
            public string? PlacaVeiculo { get; set; }
            public string? MarcaVeiculo { get; set; }
            public string? ModeloVeiculo { get; set; }
            public string? TipoVeiculo { get; set; } //Carro, Van, Furgão ou Caminhão
            public DateTime AnoVeiculo { get; set; }
            public string? TipoCombustivel { get; set; } //Álcool, Gasolina ou Etanol
            public string? SituacaoVeiculo { get; set; } //Disponivel ou Alocado

            public ICollection<Reserva>? Reservas { get; set; }

        }

        //Criando o contexto e conectando com o SQL Server
        public class ApplicationContext : DbContext
        {
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Veiculo> Veiculo { get; set; }
            public DbSet<Reserva> Reserva { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                _= optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LocaVeiculos;Trusted_Connection=True;TrustServerCertificate=True");
            
            }

        }

        //Adicionando manualmente dados ao BD para certificar que ele está funcionando
        static void Main(string[] args)
        {
            using(var context = new ApplicationContext())
            {
                //Adicionando um novo Cliente
                var cliente = new Cliente()
                {
                    Nome = "Gabriel Barbosa",
                    Telefone = "11990900800",
                    Endereco = "Estr. dos Bandeirantes, 25997 - Vargem Grande",
                    Email = "gabrielbarbosa@gmail.com",
                    EhNovoCliente = false,
                    QuantLocados = 7

                };
                context.Cliente.Add(cliente);
                context.SaveChanges();

                //Adicionando um novo Veiculo
                var veiculo = new Veiculo()
                {
                    PlacaVeiculo = "CRF8191",
                    MarcaVeiculo = "Fiat",
                    ModeloVeiculo = "Fiat500",
                    TipoVeiculo = "Carro",
                    AnoVeiculo = new DateTime(2022, 1, 1),
                    TipoCombustivel = "Gasolina",
                    SituacaoVeiculo = "Disponivel"

                };
                context.Veiculo.Add(veiculo);
                context.SaveChanges();

                //Adicionando uma nova Reserva
                var reserva = new Reserva()
                {
                    IdVeiculo = veiculo.IDVeiculo,
                    IdCliente = cliente.IdCliente,
                    DataComeco = new DateTime(2022, 2, 12),
                    DataFim = new DateTime(2022, 2, 22),
                    VaiEstender = true,
                    QuantoTempo = 10,
                    ValorTotal = 980,
                };
                context.Reserva.Add(reserva);
                context.SaveChanges();
            }
        }
    }
}
