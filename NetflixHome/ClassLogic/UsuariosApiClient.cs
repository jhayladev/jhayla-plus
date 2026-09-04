using System.Net;
using System.Net.Http.Json;

namespace NetflixHome.ClassLogic
{
    // Resultado uniforme para las llamadas de login/registro:
    // así InicioSesion.razor y Registro.razor pueden manejar el resultado igual.
    public class ResultadoAuth
    {
        public bool Exitoso { get; set; }
        public string? Mensaje { get; set; }
        public Usuarios? Usuario { get; set; }
    }

    public class UsuariosApiClient
    {
        private readonly HttpClient _http;
        private readonly ILogger<UsuariosApiClient> _logger;

        public UsuariosApiClient(IHttpClientFactory httpClientFactory, ILogger<UsuariosApiClient> logger)
        {
            _http = httpClientFactory.CreateClient("JhaylaPlusAPI");
            _logger = logger;
        }

        public async Task<ResultadoAuth> IniciarSesionAsync(string correo, string contraseña)
        {
            try
            {
                var respuesta = await _http.PostAsJsonAsync("api/usuarios/login", new { correo, contraseña });

                if (respuesta.IsSuccessStatusCode)
                {
                    var usuario = await respuesta.Content.ReadFromJsonAsync<Usuarios>();
                    return new ResultadoAuth { Exitoso = true, Usuario = usuario };
                }

                return new ResultadoAuth { Exitoso = false, Mensaje = "Correo o contraseña incorrectos." };
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo contactar a JhaylaPlusAPI para iniciar sesión.");
                return new ResultadoAuth { Exitoso = false, Mensaje = "No se pudo conectar con el servidor. Intenta de nuevo." };
            }
        }

        public async Task<ResultadoAuth> RegistrarAsync(string nombre, string apellido, string correo, string contraseña)
        {
            try
            {
                var respuesta = await _http.PostAsJsonAsync("api/usuarios/register", new { nombre, apellido, correo, contraseña });

                if (respuesta.IsSuccessStatusCode)
                {
                    var usuario = await respuesta.Content.ReadFromJsonAsync<Usuarios>();
                    return new ResultadoAuth { Exitoso = true, Usuario = usuario };
                }

                if (respuesta.StatusCode == HttpStatusCode.Conflict)
                {
                    return new ResultadoAuth { Exitoso = false, Mensaje = "Ya existe una cuenta registrada con ese correo." };
                }

                return new ResultadoAuth { Exitoso = false, Mensaje = "No se pudo crear la cuenta. Intenta de nuevo." };
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo contactar a JhaylaPlusAPI para registrar el usuario.");
                return new ResultadoAuth { Exitoso = false, Mensaje = "No se pudo conectar con el servidor. Intenta de nuevo." };
            }
        }
    }
}
