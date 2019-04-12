using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : Controller
    {
        private readonly WebContatoDbContext _context;

        public ContatosController(WebContatoDbContext context)
        {
            _context = context;
        }

        // GET: api/Contatos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contato>>> GetContato()
        {
            return await _context.Contatos.ToListAsync();
        }

        // GET: api/Contatos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contato>> GetContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);

            if (contato == null)
            {
                return NotFound();
            }

            return contato;
        }

        // PUT: api/Contatos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContato(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return BadRequest();
            }

            _context.Entry(contato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContatoExists(id))
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

        // POST: api/Contatos
        [HttpPost]
        public async Task<ActionResult<Contato>> PostContato(Contato contato)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContato", new { id = contato.Id }, contato);
        }

        // DELETE: api/Contatos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contato>> DeleteContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();

            return contato;
        }

        private bool ContatoExists(int id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }
    }
}