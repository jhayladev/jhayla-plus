using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JhaylaPlusAPI.Models;

namespace JhaylaPlusAPI.Controllers
{
    // Datos que llegan desde el botón "+" de una PeliculaCard.
    public class FavoritoRequest
    {
        public int UsuarioId { get; set; }
        public int PeliculaId { get; set; }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class FavoritosController : ControllerBase
    {
        private readonly UsuariosDbContext _usuariosContext;
        private readonly PeliculasDbContext _peliculasContext;

        public FavoritosController(UsuariosDbContext usuariosContext, PeliculasDbContext peliculasContext)
        {
            _usuariosContext = usuariosContext;
            _peliculasContext = peliculasContext;
        }

        // GET: api/favoritos/5
        // Devuelve las películas completas que el usuario 5 tiene guardadas en "Mi Lista".
        [HttpGet("{usuarioId:int}")]
        public async Task<ActionResult<IEnumerable<Peliculas>>> GetFavoritos(int usuarioId)
        {
            var idsPeliculas = await _usuariosContext.Favoritos
                .AsNoTracking()
                .Where(f => f.UsuarioId == usuarioId)
                .Select(f => f.PeliculaId)
                .ToListAsync();

            if (idsPeliculas.Count == 0)
            {
                return Ok(new List<Peliculas>());
            }

            var peliculas = await _peliculasContext.Peliculas
                .AsNoTracking()
                .Where(p => idsPeliculas.Contains(p.Id))
                .ToListAsync();

            return Ok(peliculas);
        }

        // POST: api/favoritos
        // Agrega una película a "Mi Lista". Si ya estaba, no la duplica.
        [HttpPost]
        public async Task<IActionResult> AgregarFavorito([FromBody] FavoritoRequest request)
        {
            var yaExiste = await _usuariosContext.Favoritos
                .AnyAsync(f => f.UsuarioId == request.UsuarioId && f.PeliculaId == request.PeliculaId);

            if (yaExiste)
            {
                return Ok(new { mensaje = "La película ya estaba en la lista." });
            }

            _usuariosContext.Favoritos.Add(new Favorito
            {
                UsuarioId = request.UsuarioId,
                PeliculaId = request.PeliculaId
            });

            await _usuariosContext.SaveChangesAsync();

            return Ok(new { mensaje = "Agregada a Mi Lista." });
        }

        // DELETE: api/favoritos/5/12  (usuarioId/peliculaId)
        [HttpDelete("{usuarioId:int}/{peliculaId:int}")]
        public async Task<IActionResult> QuitarFavorito(int usuarioId, int peliculaId)
        {
            var favorito = await _usuariosContext.Favoritos
                .FirstOrDefaultAsync(f => f.UsuarioId == usuarioId && f.PeliculaId == peliculaId);

            if (favorito is null)
            {
                return NotFound();
            }

            _usuariosContext.Favoritos.Remove(favorito);
            await _usuariosContext.SaveChangesAsync();

            return Ok(new { mensaje = "Removida de Mi Lista." });
        }
    }
}
