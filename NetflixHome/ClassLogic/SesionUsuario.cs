namespace NetflixHome.ClassLogic
{
    public class SesionUsuario
    {
        public Usuarios? UsuarioActual { get; private set; }

        public bool HaIniciadoSesion => UsuarioActual is not null;

        // Permite que otros componentes (NavMenu, PeliculaCard, FavoritosService...)
        // se enteren cuando alguien inicia o cierra sesión sin depender de una
        // navegación de página completa.
        public event Action? OnCambio;

        public void IniciarSesion(Usuarios usuario)
        {
            UsuarioActual = usuario;
            OnCambio?.Invoke();
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
            OnCambio?.Invoke();
        }
    }
}
