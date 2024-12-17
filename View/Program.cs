using View.Components;
using ProyectoGym.src.Model.Context;
using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Controller;
using src.Model.Personas;
using src.Model.Inventario;
using src.Model.Gestion;
using src.Model.Finanzas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<GymContext>(opciones =>
{

    opciones.UseSqlServer("Server=DESKTOP-6EQ9TGO;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True");

});

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddScoped<Person>();
builder.Services.AddScoped<Maquina>();
builder.Services.AddScoped<Clase>();
builder.Services.AddScoped<Reporte>();
builder.Services.AddScoped<Membresia>();
builder.Services.AddScoped<ClientesController>();
builder.Services.AddScoped<ReporteController>();
builder.Services.AddScoped<MaquinaController>();
builder.Services.AddScoped<PersonaController>();
builder.Services.AddScoped<MembresiaController>();
builder.Services.AddScoped<EntrenadorController>();
builder.Services.AddScoped<ClaseController>();
builder.Services.AddScoped<Cliente>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
