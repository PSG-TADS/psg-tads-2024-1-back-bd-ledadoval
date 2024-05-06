using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ConsoleLocaVeiculos.Context;
using Swashbuckle.AspNetCore;

namespace ConsoleLocaVeiculos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurando o serviço de conexão com o banco de dados
            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString(@"Server=.\SQLEXPRESS;Database=LocaVeiculos;Trusted_Connection=True;TrustServerCertificate=True")));
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ConsoleLocaVeiculos", Version = "v1" });
            });


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConsoleLocaVeiculos");
                    c.RoutePrefix = string.Empty; 
                });

            app.UseRouting();
            app.UseAuthorization();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                {
                    context.Response.Redirect("/swagger/index.html");
                    return;
                }

                await next();
            });

            app.MapGet("/", () => "Hello World!");


            app.Run();
                }

        private static object async(object context, object next)
        {
            throw new NotImplementedException();
        }
    }
        }

/*
//Adicionando manualmente dados ao BD para certificar que ele está funcionando
static void Main(string[] args)
                        {
    using(var context = new ApplicationContext())
                    {
        //Adicionando um novo Cliente
        var cliente = new Cliente()
                        {
            Nome = "Richard Montaya",
            Telefone = "011673398212",
            Endereco = "Medelin - Colombia",
            Email = "richardmontoya@gmail.com",
            EhNovoCliente = true,
            QuantLocados = 0

        };
        context.Cliente.Add(cliente);
        context.SaveChanges();

        //Adicionando um novo Veiculo
        var veiculo = new Veiculo()
                            {
            PlacaVeiculo = "SEP2023",
            MarcaVeiculo = "RAM",
            ModeloVeiculo = "Dodge RAM",
            TipoVeiculo = "Carro",
            AnoVeiculo = new DateTime(2024, 1, 1),
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
            DataComeco = new DateTime(2024, 1, 16),
            DataFim = new DateTime(2024, 1, 22),
            VaiEstender = false,
            QuantoTempo = 0,
            ValorTotal = 2550,
        };
        context.Reserva.Add(reserva);
        context.SaveChanges();
    }
}
*/