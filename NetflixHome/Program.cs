using NetflixHome.ClassLogic;
using NetflixHome.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Cliente HTTP hacia JhaylaPlusAPI (la Base URL se toma de appsettings.json -> "ApiBaseUrl").
var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? "http://localhost:50428/";
builder.Services.AddHttpClient("JhaylaPlusAPI", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddScoped<PeliculasApiClient>();
builder.Services.AddScoped<ToastService>();
builder.Services.AddScoped<UsuariosApiClient>();
builder.Services.AddScoped<SesionUsuario>();
builder.Services.AddScoped<BusquedaService>();
builder.Services.AddScoped<FavoritosApiClient>();
builder.Services.AddScoped<FavoritosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
