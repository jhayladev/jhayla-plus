using System.Net.Http.Json;

namespace NetflixHome.ClassLogic
{
    public class PeliculasApiClient
    {
        private readonly HttpClient _http;
        private readonly ILogger<PeliculasApiClient> _logger;

        public PeliculasApiClient(IHttpClientFactory httpClientFactory, ILogger<PeliculasApiClient> logger)
        {
            _http = httpClientFactory.CreateClient("JhaylaPlusAPI");
            _logger = logger;
        }

        public async Task<List<Peliculas>> ObtenerTodasAsync()
        {
            try
            {
                var peliculas = await _http.GetFromJsonAsync<List<Peliculas>>("api/peliculas");
                if (peliculas is { Count: > 0 })
                {
                    return peliculas;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "No se pudo obtener el catálogo desde JhaylaPlusAPI, se usará el catálogo local de respaldo.");
            }

            return PeliculasRepository.Todas;
        }
    }
}
