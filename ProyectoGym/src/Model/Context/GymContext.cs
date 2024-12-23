﻿using Microsoft.EntityFrameworkCore;
using Model.Gestion;
using src.Model.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Metrica> Metricas { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }



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

            modelBuilder.Entity<Clase>()
                .HasOne(clase => clase.Entrenador)
                .WithMany(entrenador => entrenador.Clases)
                .HasForeignKey(clase => clase.EntrenadorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Membresia)
                .WithOne(m => m.Cliente)
                .HasForeignKey<Membresia>(m => m.ClienteID);

        }
    }
}