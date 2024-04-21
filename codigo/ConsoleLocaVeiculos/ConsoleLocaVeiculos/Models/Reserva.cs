using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleLocaVeiculos;

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