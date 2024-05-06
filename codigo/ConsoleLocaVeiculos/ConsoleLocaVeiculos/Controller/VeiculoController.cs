using ConsoleLocaVeiculos.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsoleLocaVeiculos.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public VeiculoController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Veiculo
        [HttpGet]
              public ActionResult<IEnumerable<Veiculo>> GetVeiculo()
        {
            return _context.Veiculo.ToList();
        }

        // GET: api/Veiculo/5
        [HttpGet("{id}")]
        public ActionResult<Veiculo> GetVeiculo(int id)
        {
            var veiculo = _context.Veiculo.Find(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;
        }

        // PUT: api/Veiculo/5
        [HttpPut("{id}")]
        public IActionResult AtualizarVeiculo(int id, [FromBody] Veiculo veiculoAtualizado)
        {
            var veiculo = _context.Veiculo.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            veiculo.PlacaVeiculo = veiculoAtualizado.PlacaVeiculo;
            veiculo.MarcaVeiculo = veiculoAtualizado.MarcaVeiculo;
            veiculo.ModeloVeiculo = veiculoAtualizado.ModeloVeiculo;
            veiculo.TipoVeiculo = veiculoAtualizado.TipoVeiculo;
            veiculo.AnoVeiculo = veiculoAtualizado.AnoVeiculo;
            veiculo.TipoCombustivel = veiculoAtualizado.TipoCombustivel;
            veiculo.SituacaoVeiculo = veiculoAtualizado.SituacaoVeiculo;

            _context.SaveChanges();
            return Ok(veiculo);
        }

        // POST: api/Veiculo
        [HttpPost]
        public IActionResult CriarVeiculo([FromBody] Veiculo veiculo)
        {
            // Verifica se já existe um veículo com a mesma placa
            if (_context.Veiculo.Any(v => v.PlacaVeiculo == veiculo.PlacaVeiculo))
            {
                return Conflict("Já existe um veículo com a mesma placa.");
            }

            _context.Veiculo.Add(veiculo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetVeiculo), new { id = veiculo.IDVeiculo }, veiculo);
        }

        // DELETE: api/Veiculo/5
        [HttpDelete("{id}")]
        public IActionResult DeletarVeiculo(int id)
        {
            var veiculo = _context.Veiculo.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }
            _context.Veiculo.Remove(veiculo);
            _context.SaveChanges();
            return NoContent();
        }

        private bool VeiculoExists(int id)
        {
            return _context.Veiculo.Any(e => e.IDVeiculo == id);
        }
    }
}
