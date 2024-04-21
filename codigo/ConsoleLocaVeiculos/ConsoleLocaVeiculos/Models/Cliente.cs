using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleLocaVeiculos;

public class Cliente
{
    // Declarando a PK de Cliente
    [Key]
    public int IdCliente { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }
    public string? Email { get; set; }
    public Boolean EhNovoCliente { get; set; } //Para saber se o cliente j� � antigo na loja ou n�o, visando futuras promo��es
    public int QuantLocados { get; set; } //Saber quantos veiculos o cliente j� alugou

    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

}