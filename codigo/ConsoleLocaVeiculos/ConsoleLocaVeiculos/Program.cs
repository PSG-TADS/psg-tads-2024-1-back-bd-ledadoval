using System;
using ConsoleLocaVeiculos.Context;



namespace ConsoleLocaVeiculos
{
    public class Program
    {

        //Adicionando manualmente dados ao BD para certificar que ele está funcionando
        static void Main(string[] args)
        {
            using(var context = new ApplicationContext())
            {
                //Adicionando um novo Cliente
                var cliente = new Cliente()
                {
                    Nome = "Joaquin Moreira",
                    Telefone = "0116789998212",
                    Endereco = "Barra Funda - SP",
                    Email = "joaquinmoreira@gmail.com",
                    EhNovoCliente = true,
                    QuantLocados = 0

                };
                context.Cliente.Add(cliente);
                context.SaveChanges();

                //Adicionando um novo Veiculo
                var veiculo = new Veiculo()
                {
                    PlacaVeiculo = "UFA2022",
                    MarcaVeiculo = "RAM",
                    ModeloVeiculo = "RAM Tchum",
                    TipoVeiculo = "Carro",
                    AnoVeiculo = new DateTime(2023, 1, 1),
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
                    DataComeco = new DateTime(2024, 3, 16),
                    DataFim = new DateTime(2024, 3, 22),
                    VaiEstender = true,
                    QuantoTempo = 5,
                    ValorTotal = 2550,
                };
                context.Reserva.Add(reserva);
                context.SaveChanges();
            }
        }

    }
}
