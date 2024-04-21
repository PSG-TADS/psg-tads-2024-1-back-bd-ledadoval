using ConsoleLocaVeiculos.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleLocaVeiculos;

namespace ConsoleLocaVeiculos.Controller
{
    namespace ConsoleLocaVeiculos.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ReservaController : ControllerBase
        {
            private readonly ApplicationContext _context;

            public ReservaController(ApplicationContext context)
            {
                _context = context;
            }

            // GET: api/Reserva
            [HttpGet]
            public ActionResult<IEnumerable<Reserva>> GetReservas()
            {
                return _context.Reserva.ToList();
            }

            // GET: api/Reserva/5
            [HttpGet("{id}")]
            public ActionResult<Reserva> GetReserva(int id)
            {
                var reserva = _context.Reserva.Find(id);

                if (reserva == null)
                {
                    return NotFound();
                }

                return reserva;
            }

            // POST: api/Reserva
            [HttpPost]
            public async Task<ActionResult<Reserva>> PostReserva(Reserva reserva)
            {
                if (ReservaExists(reserva.IdReserva))
                {
                    return Conflict();
                }

                _context.Reserva.Add(reserva);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetReserva), new { id = reserva.IdReserva }, reserva);
            }

            // DELETE: api/Reserva/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteReserva(int id)
            {
                var reserva = await _context.Reserva.FindAsync(id);
                if (reserva == null)
                {
                    return NotFound();
                }

                _context.Reserva.Remove(reserva);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool ReservaExists(int id)
            {
                return _context.Reserva.Any(e => e.IdReserva == id);
            }
        }
    }
    }

