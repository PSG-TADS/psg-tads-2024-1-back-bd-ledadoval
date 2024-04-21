using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleLocaVeiculos;

public class Reserva
{
    //Declarando a PK de Reserva
    [Key]
    public int IdReserva { get; set; }
    //FK de Reserva ser� a PK de Cliente
    public int IdCliente { get; set; }
    [ForeignKey("IdCliente")]
    //FK de Reserva ser� a PK de Veiculo
    public int IdVeiculo { get; set; }
    [ForeignKey("IdVeiculo")]

    public DateTime DataComeco { get; set; }
    public DateTime DataFim { get; set; }
    public Boolean VaiEstender { get; set; } //Caso o cliente queira mais tempo da loca��o do que estipulado no contrato
    public int QuantoTempo { get; set; } //Quanto tempo o cliente ficar� caso estenda o contrato
    public int ValorTotal { get; set; } //O valor total levar� em considera��o se o cliente estendeu o contrato ou n�o
}