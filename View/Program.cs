using View.Components;
using ProyectoGym.src.Model.Context;
using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Controller;
using src.Model.Personas;
using src.Model.Inventario;
using src.Model.Gestion;
using src.Model.Finanzas;
using BlazorDownloadFile;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazorDownloadFile();

builder.Services.AddDbContext<GymContext>(opciones =>
{
    opciones.UseSqlServer("Server=DESKTOP-6EQ9TGO;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True");
});

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddScoped<Person>();
builder.Services.AddScoped<Maquina>();
builder.Services.AddScoped<Clase>();
builder.Services.AddScoped<Entrenador>();
builder.Services.AddScoped<Reserva>();
builder.Services.AddScoped<Reporte>();
builder.Services.AddScoped<Factura>();
builder.Services.AddScoped<Membresia>();
builder.Services.AddScoped<ClientesController>();
builder.Services.AddScoped<ReporteMatriculaController>();
builder.Services.AddScoped<MaquinaController>();
builder.Services.AddScoped<PersonaController>();
builder.Services.AddScoped<ReservaController>();
builder.Services.AddScoped<MembresiaController>();
builder.Services.AddScoped<EntrenadorController>();
builder.Services.AddScoped<FacturaController>();
builder.Services.AddScoped<RutinaController>();
builder.Services.AddScoped<MetricaController>();
builder.Services.AddScoped<ClaseController>();
builder.Services.AddScoped<Cliente>();
builder.Services.AddScoped<Categoria>();
builder.Services.AddScoped<CategoriaController>();
builder.Services.AddScoped<ReporteIngresosController>();
builder.Services.AddScoped<ReporteClasesController>();



QuestPDF.Settings.License = LicenseType.Community;

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
