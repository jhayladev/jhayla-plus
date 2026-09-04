using Microsoft.EntityFrameworkCore;
using JhaylaPlusAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// 1. Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConnectionJhaylaDB");

// 2. Registrar el DbContext -- Peliculas
builder.Services.AddDbContext<PeliculasDbContext>(options =>
    options.UseSqlServer(connectionString));

// 3. Registrar el DbContext -- Usuarios    
builder.Services.AddDbContext<UsuariosDbContext>(options =>
    options.UseSqlServer(connectionString));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<PeliculasDbContext>();
        context.Database.Migrate(); // Aplica InitialCreate y SeedPeliculasData en SQL Server

        var usuariosContext = services.GetRequiredService<UsuariosDbContext>();
        usuariosContext.Database.Migrate(); // Aplica la migración UsuariosDb (tabla + usuarios de prueba)
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al aplicar migraciones: {ex.Message}");
    }
}

app.Run();
