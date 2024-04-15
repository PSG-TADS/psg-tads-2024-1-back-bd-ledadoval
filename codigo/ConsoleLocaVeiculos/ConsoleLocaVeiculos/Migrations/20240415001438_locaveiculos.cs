using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleLocaVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class locaveiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EhNovoCliente = table.Column<bool>(type: "bit", nullable: false),
                    QuantLocados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    IDVeiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoVeiculo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoCombustivel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.IDVeiculo);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdVeiculo = table.Column<int>(type: "int", nullable: false),
                    DataComeco = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaiEstender = table.Column<bool>(type: "bit", nullable: false),
                    QuantoTempo = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<int>(type: "int", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: true),
                    VeiculoIDVeiculo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Reserva_Veiculo_VeiculoIDVeiculo",
                        column: x => x.VeiculoIDVeiculo,
                        principalTable: "Veiculo",
                        principalColumn: "IDVeiculo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteIdCliente",
                table: "Reserva",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_VeiculoIDVeiculo",
                table: "Reserva",
                column: "VeiculoIDVeiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
