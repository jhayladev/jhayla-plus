using System.Net.Http.Json;

namespace NetflixHome.ClassLogic
{
    public class FavoritosApiClient
    {
        private readonly HttpClient _http;
        private readonly ILogger<FavoritosApiClient> _logger;

        public FavoritosApiClient(IHttpClientFactory httpClientFactory, ILogger<FavoritosApiClient> logger)
        {
            _http = httpClientFactory.CreateClient("JhaylaPlusAPI");
            _logger = logger;
        }

        public async Task<List<Peliculas>> ObtenerFavoritasAsync(int usuarioId)
        {
            try
            {
                var favoritas = await _http.GetFromJsonAsync<List<Peliculas>>($"api/favoritos/{usuarioId}");
                return favoritas ?? new List<Peliculas>();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo obtener Mi Lista desde JhaylaPlusAPI.");
                return new List<Peliculas>();
            }
        }

        public async Task<bool> AgregarAsync(int usuarioId, int peliculaId)
        {
            try
            {
                var respuesta = await _http.PostAsJsonAsync("api/favoritos", new { usuarioId, peliculaId });
                return respuesta.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo agregar la película {Id} a Mi Lista.", peliculaId);
                return false;
            }
        }

        public async Task<bool> QuitarAsync(int usuarioId, int peliculaId)
        {
            try
            {
                var respuesta = await _http.DeleteAsync($"api/favoritos/{usuarioId}/{peliculaId}");
                return respuesta.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo quitar la película {Id} de Mi Lista.", peliculaId);
                return false;
            }
        }
    }
}
