# Jhayla Plus 🎬

Plataforma web estilo **Netflix**, compuesta por dos proyectos .NET independientes dentro de una misma solución: un **frontend en Blazor Server** que muestra el catálogo de películas, y una **API REST** encargada de exponer y persistir esos datos en SQL Server.

> Estado actual: el frontend funciona de forma visual con datos de ejemplo en memoria. La API ya tiene el modelo, el `DbContext` y la migración inicial de base de datos, pero **todavía no expone endpoints propios de películas** ni el frontend consume la API aún (ver [Estado actual y roadmap](#-estado-actual-y-roadmap)).

## 🧱 Tecnologías

- **.NET 10**
- **ASP.NET Core Blazor** (Interactive Server Components) — frontend
- **ASP.NET Core Web API** con controladores — backend
- **Entity Framework Core 10** + **SQL Server** — persistencia
- **Bootstrap 5** para estilos base
- CSS aislado por componente (`.razor.css`)

## 📁 Estructura de la solución

```
jhayla-plus-main/
├── slnNetflixHome.slnx          # Solución que agrupa ambos proyectos
│
├── NetflixHome/                 # Frontend — Blazor Server
│   ├── CarruselBanner/
│   │   └── Carrusel.razor       # Banner principal (película destacada)
│   ├── Cards/
│   │   ├── ListaPeliculas.razor # Fila/contenedor de tarjetas de películas
│   │   └── PeliculaCard.razor   # Tarjeta individual (título, imagen, año)
│   ├── ClassLogic/
│   │   ├── Peliculas.cs             # Modelo: Id, Titulo, ImagenUrl, Year
│   │   └── PeliculasRepository.cs   # Fuente de datos de ejemplo en memoria
│   ├── Components/
│   │   ├── Layout/               # MainLayout, NavMenu, ReconnectModal
│   │   ├── Pages/                # Home, Counter, Weather, NotFound, Error
│   │   ├── App.razor              # Documento raíz HTML
│   │   └── Routes.razor
│   ├── wwwroot/
│   │   ├── images/                # Imágenes locales del proyecto
│   │   └── app.css                # Estilos globales
│   └── Program.cs                 # Configuración y arranque de la app
│
└── JhaylaPlusAPI/                # Backend — Web API
    ├── Controllers/
    │   └── WeatherForecastController.cs  # Controlador de plantilla (pendiente reemplazar/ampliar)
    ├── Models/
    │   ├── Peliculas.cs               # Entidad: Id, Titulo, ImagenUrl, Year
    │   └── PeliculasDbContext.cs      # DbContext de EF Core (DbSet<Peliculas>)
    ├── Migrations/
    │   └── InitialCreate               # Crea la tabla "Peliculas" en SQL Server
    ├── Program.cs                      # Registro de DbContext, controladores y OpenAPI
    └── appsettings.json                # Cadena de conexión "ConnectionJhaylaDB"
```

## ⚙️ Funcionamiento general

1. **`NetflixHome` (frontend)** renderiza la página de inicio con:
   - Un **carrusel/banner** (`Carrusel.razor`) que destaca una película tomada de `PeliculasRepository.Destacada`.
   - Dos **filas de tarjetas** (`ListaPeliculas.razor` + `PeliculaCard.razor`) que listan el catálogo completo y una versión reordenada, simulando secciones tipo "Añadido recientemente" y "Recomendado para ti".
   - Por ahora, todos estos datos provienen de una lista estática en `PeliculasRepository.cs` (sin base de datos ni HTTP de por medio).

2. **`JhaylaPlusAPI` (backend)** está pensada para ser la fuente real de datos:
   - Define la entidad `Peliculas` y un `PeliculasDbContext` de EF Core.
   - Se conecta a SQL Server mediante la cadena `ConnectionJhaylaDB` en `appsettings.json`.
   - Ya cuenta con una migración (`InitialCreate`) que crea la tabla `Peliculas`.
   - Actualmente solo expone el controlador de ejemplo `WeatherForecastController` (plantilla por defecto); aún falta un controlador CRUD para `Peliculas`.

3. Los dos proyectos **todavía no están conectados entre sí**: el frontend no hace llamadas HTTP hacia la API. Esa integración es el siguiente paso natural del proyecto.

## ▶️ Cómo ejecutar el proyecto

### Requisitos previos

- .NET 10 SDK
- SQL Server (local o Express) si se quiere levantar también la API

### 1. Frontend (NetflixHome)

```bash
cd NetflixHome
dotnet restore
dotnet run
```

Abrir la URL indicada en la consola (por defecto algo como `https://localhost:xxxx`).

### 2. API (JhaylaPlusAPI)

```bash
cd JhaylaPlusAPI
dotnet restore
dotnet ef database update   # aplica la migración InitialCreate
dotnet run
```

Verificar/ajustar antes la cadena de conexión en `appsettings.json`:

```json
"ConnectionStrings": {
  "ConnectionJhaylaDB": "Server=localhost\\SQLEXPRESS;Database=JhaylaDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Solución completa

También se puede abrir `slnNetflixHome.slnx` en Visual Studio y ejecutar ambos proyectos como *startup projects* múltiples.

## 📌 Estado actual y roadmap

**Ya implementado:**
- [x] Frontend Blazor con banner y catálogo de tarjetas funcionando visualmente.
- [x] Proyecto de API separado, con EF Core y SQL Server configurados.
- [x] Modelo `Peliculas` y migración inicial de base de datos en la API.

**Pendiente:**
- [ ] Crear un `PeliculasController` en la API con endpoints CRUD (`GET`, `POST`, `PUT`, `DELETE`).
- [ ] Reemplazar `WeatherForecastController` (plantilla) o dejarlo solo como ejemplo aparte.
- [ ] Consumir la API desde `NetflixHome` mediante `HttpClient`, en lugar de `PeliculasRepository` en memoria.
- [ ] Definir DTOs y capa de mapeo entre la API y el modelo usado en la UI.
- [ ] Poblar la base de datos con las películas de ejemplo (seed data) para reemplazar la lista hardcodeada.
- [ ] Documentar variables de entorno / cadena de conexión para distintos entornos (desarrollo, producción).

## 🗒️ Notas

- Los modelos `Peliculas` de `NetflixHome/ClassLogic` y de `JhaylaPlusAPI/Models` son actualmente **independientes y duplicados** (misma forma, distinto namespace); al integrar la API se recomienda unificar esto con un DTO compartido o un paquete común.
- Algunas imágenes del catálogo de ejemplo apuntan a URLs externas (pósters); al migrar a base de datos conviene revisar la persistencia/almacenamiento de estas imágenes.
