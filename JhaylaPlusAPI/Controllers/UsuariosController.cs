using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JhaylaPlusAPI.Models;

namespace JhaylaPlusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosDbContext _context;

        public UsuariosController(UsuariosDbContext context)
        {
            _context = context;
        }

        // GET: api/usuarios
        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _context.Usuarios
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .ToListAsync();
            return Ok(usuarios);
        }

        // GET: api/usuarios/5
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetUsuario(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);

            if (usuarios is null)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }
    }
}