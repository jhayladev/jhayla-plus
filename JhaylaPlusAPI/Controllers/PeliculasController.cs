using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JhaylaPlusAPI.Models;

namespace JhaylaPlusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly PeliculasDbContext _context;

        public PeliculasController(PeliculasDbContext context)
        {
            _context = context;
        }

        // GET: api/peliculas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peliculas>>> GetPeliculas()
        {
            var peliculas = await _context.Peliculas
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .ToListAsync();

            return Ok(peliculas);
        }

        // GET: api/peliculas/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Peliculas>> GetPelicula(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);

            if (pelicula is null)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}
