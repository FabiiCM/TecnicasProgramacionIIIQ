using Microsoft.EntityFrameworkCore;
using Model.Gestion;
using src.Model.Personas;
using ProyectoGym.src.Model.Finanzas;
using src.Model.Inventario;
using src.Model.Gestion;
using src.Model.Finanzas;

namespace ProyectoGym.src.Model.Context
{
    public class GymContext : DbContext
    {
        public DbSet<Person> Personas { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Reporte> Reportes { get; set; }



        public GymContext(DbContextOptions opciones) : base(opciones) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("TipoPersona")
                .HasValue<Cliente>("Cliente")
                .HasValue<Entrenador>("Entrenador");

            modelBuilder.Entity<Reserva>()
                .HasOne(reserva => reserva.Cliente)
                .WithMany(cliente => cliente.Reservas)
                .HasForeignKey(reserva => reserva.ClienteID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}