namespace NetflixHome.ClassLogic
{
    // Mismo patrón que ToastService: un evento simple para comunicar
    // el NavMenu (quien escribe la búsqueda) con Home (quien filtra el catálogo).
    public class BusquedaService
    {
        public string Texto { get; private set; } = string.Empty;

        public event Action<string>? OnBuscar;

        public void Buscar(string texto)
        {
            Texto = texto ?? string.Empty;
            OnBuscar?.Invoke(Texto);
        }
    }
}
