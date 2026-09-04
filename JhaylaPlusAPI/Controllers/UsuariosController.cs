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

        // POST: api/usuarios/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var usuario = await _context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Correo == request.Correo && u.Contraseña == request.Contraseña);

            if (usuario is null)
            {
                return Unauthorized(new { mensaje = "Correo o contraseña incorrectos." });
            }

            return Ok(usuario);
        }

        // POST: api/usuarios/register
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var yaExiste = await _context.Usuarios.AnyAsync(u => u.Correo == request.Correo);
            if (yaExiste)
            {
                return Conflict(new { mensaje = "Ya existe una cuenta registrada con ese correo." });
            }

            var nuevoUsuario = new Usuarios
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Correo = request.Correo,
                Contraseña = request.Contraseña
            };

            _context.Usuarios.Add(nuevoUsuario);
            await _context.SaveChangesAsync();

            return Ok(nuevoUsuario);
        }
    }
}