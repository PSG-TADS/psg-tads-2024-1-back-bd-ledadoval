using ConsoleLocaVeiculos.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleLocaVeiculos.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClienteController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Cliente.ToListAsync();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return BadRequest();
            }

            var existingCliente = await _context.Cliente.FindAsync(id);
            if (existingCliente == null)
            {
                return NotFound();
            }

            existingCliente.Nome = cliente.Nome;
            existingCliente.Telefone = cliente.Telefone;
            existingCliente.Endereco = cliente.Endereco;
            existingCliente.Email = cliente.Email;
            existingCliente.EhNovoCliente = cliente.EhNovoCliente;
            existingCliente.QuantLocados = cliente.QuantLocados;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            // Verifica se já existe um cliente com o mesmo email
            if (_context.Cliente.Any(c => c.Email == cliente.Email))
            {
                return Conflict("Já existe um cliente com o mesmo email.");
            }

            // Verifica se já existe um cliente com o mesmo telefone
            if (_context.Cliente.Any(c => c.Telefone == cliente.Telefone))
            {
                return Conflict("Já existe um cliente com o mesmo telefone.");
            }

            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCliente), new { id = cliente.IdCliente }, cliente);
        }

        // DELETE: api/Cliente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.IdCliente == id);
        }
    }
}
