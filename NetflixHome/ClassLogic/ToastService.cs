namespace NetflixHome.ClassLogic
{
    // Servicio (scoped) para mostrar mensajes tipo "toast" desde cualquier componente,
    // por ejemplo cuando se le da al "+" de una tarjeta.
    public class ToastService
    {
        public event Action<string>? OnShow;

        public void Mostrar(string mensaje)
        {
            OnShow?.Invoke(mensaje);
        }
    }
}
