using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleLocaVeiculos;

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