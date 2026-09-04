namespace NetflixHome.ClassLogic
{
    // Guarda en memoria (por circuito de Blazor) los IDs de las películas que
    // el usuario logueado tiene en "Mi Lista", para que cada PeliculaCard sepa
    // si debe mostrarse marcada sin tener que llamar a la API por cada tarjeta.
    public class FavoritosService
    {
        private readonly FavoritosApiClient _api;
        private readonly SesionUsuario _sesion;
        private readonly HashSet<int> _idsFavoritos = new();

        public event Action? OnCambio;

        public FavoritosService(FavoritosApiClient api, SesionUsuario sesion)
        {
            _api = api;
            _sesion = sesion;
            _sesion.OnCambio += AlCambiarSesion;
        }

        // Se dispara al iniciar/cerrar sesión: carga o limpia la lista según corresponda.
        private async void AlCambiarSesion()
        {
            if (_sesion.HaIniciadoSesion && _sesion.UsuarioActual is not null)
            {
                await CargarAsync(_sesion.UsuarioActual.Id);
            }
            else
            {
                _idsFavoritos.Clear();
                OnCambio?.Invoke();
            }
        }

        public async Task CargarAsync(int usuarioId)
        {
            var favoritas = await _api.ObtenerFavoritasAsync(usuarioId);
            _idsFavoritos.Clear();
            foreach (var pelicula in favoritas)
            {
                _idsFavoritos.Add(pelicula.Id);
            }
            OnCambio?.Invoke();
        }

        public bool EsFavorita(int peliculaId) => _idsFavoritos.Contains(peliculaId);

        // Devuelve true si la operación contra la API tuvo éxito.
        // Después de llamarla, usar EsFavorita(id) para saber el nuevo estado.
        public async Task<bool> AlternarAsync(int peliculaId)
        {
            if (!_sesion.HaIniciadoSesion || _sesion.UsuarioActual is null)
            {
                return false;
            }

            var usuarioId = _sesion.UsuarioActual.Id;
            bool exito;

            if (_idsFavoritos.Contains(peliculaId))
            {
                exito = await _api.QuitarAsync(usuarioId, peliculaId);
                if (exito)
                {
                    _idsFavoritos.Remove(peliculaId);
                }
            }
            else
            {
                exito = await _api.AgregarAsync(usuarioId, peliculaId);
                if (exito)
                {
                    _idsFavoritos.Add(peliculaId);
                }
            }

            if (exito)
            {
                OnCambio?.Invoke();
            }

            return exito;
        }

        public Task<List<Peliculas>> ObtenerListaCompletaAsync()
        {
            if (_sesion.UsuarioActual is null)
            {
                return Task.FromResult(new List<Peliculas>());
            }

            return _api.ObtenerFavoritasAsync(_sesion.UsuarioActual.Id);
        }
    }
}
