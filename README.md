# NetflixHome

Página de inicio estilo Netflix construida con **Blazor Server (.NET 10)**, que muestra un banner tipo carrusel y un catálogo de películas en tarjetas.

## 🧱 Tecnologías

- **.NET 10** / **ASP.NET Core Blazor** (Interactive Server Components)
- **Bootstrap 5** para estilos base
- CSS aislado por componente (`.razor.css`)

## 📁 Estructura del proyecto

```
NetflixHome/
├── CarruselBanner/
│   └── Carrusel.razor          # Banner principal (carrusel de destacados)
├── Cards/
│   ├── ListaPeliculas.razor     # Contenedor que renderiza la lista de películas
│   └── PeliculaCard.razor       # Tarjeta individual de película (título, imagen, año)
├── ClassLogic/
│   └── Pelicula.cs              # Modelo de datos: Titulo, ImagenUrl, Year
├── Components/
│   ├── Layout/                  # MainLayout, NavMenu, ReconnectModal
│   ├── Pages/                   # Home, Counter, Weather, NotFound, Error
│   ├── App.razor                # Documento raíz HTML
│   └── Routes.razor
├── wwwroot/
│   ├── images/                  # Imágenes locales del proyecto
│   └── app.css                  # Estilos globales
└── Program.cs                    # Configuración y arranque de la app
```

## ▶️ Cómo ejecutar el proyecto

1. Clonar o descomprimir el repositorio.
2. Abrir `slnNetflixHome.slnx` en Visual Studio, o ejecutar desde consola:
   ```bash
   cd NetflixHome
   dotnet restore
   dotnet run
   ```
3. Abrir la URL indicada en la consola (por defecto `https://localhost:xxxx`).

## 📌 Estado actual

- El catálogo de películas (`ListaPeliculas.razor`) usa una **lista en memoria hardcodeada** como datos de prueba.
- No existe todavía persistencia de datos ni una capa de servicios/API.

## 🚧 Próximos pasos (roadmap)

Este proyecto se encuentra en desarrollo activo. Próximamente se implementará:

- [ ] **Base de datos en SQL Server** para persistir el catálogo de películas (y posibles entidades relacionadas: categorías, usuarios, etc.).
- [ ] **API REST** para exponer las operaciones CRUD sobre las películas, desacoplando el frontend Blazor de los datos.
- [ ] Reemplazar la lista estática en `ListaPeliculas.razor` por **llamadas HTTP** (vía `HttpClient`) hacia la API.
- [ ] Definir un **DTO** y capa de mapeo entre la API y el modelo `Pelicula` usado en la UI.

## 🗒️ Notas

- El componente `Carrusel.razor` actualmente muestra una imagen fija de ejemplo; se espera que en el futuro consuma también datos dinámicos (destacados) desde la API.
- Al integrar SQL Server, se recomienda documentar aquí la cadena de conexión esperada (vía `appsettings.json` / variables de entorno) y las migraciones utilizadas (EF Core u otro ORM).
