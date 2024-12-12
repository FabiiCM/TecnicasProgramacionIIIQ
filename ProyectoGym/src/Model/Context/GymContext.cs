using Microsoft.EntityFrameworkCore;
using Model.Gestion;
using Model.Personas;
using Model.Finanzas;
using Model.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGym.Model.Context
{
    public class GymContext : DbContext
    {
        public DbSet<Person> Personas { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }



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