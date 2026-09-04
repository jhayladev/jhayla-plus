namespace JhaylaPlusAPI.Models
{
    // Datos que llegan desde el formulario de InicioSesion.razor
    public class LoginRequest
    {
        public string Correo { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
    }

    // Datos que llegan desde el formulario de Registro.razor
    public class RegisterRequest
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
    }
}
