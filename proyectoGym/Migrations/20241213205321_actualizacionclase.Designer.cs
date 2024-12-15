﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoGym.src.Model.Context;

#nullable disable

namespace ProyectoGym.Migrations
{
    [DbContext(typeof(GymContext))]
    [Migration("20241213205321_actualizacionclase")]
    partial class actualizacionclase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoGym.src.Model.Finanzas.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("ProyectoGym.src.Model.Finanzas.Ingreso", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Concepto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Ingresos");
                });

            modelBuilder.Entity("src.Model.Finanzas.Reporte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Reportes");
                });

            modelBuilder.Entity("src.Model.Gestion.Clase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CupoMaximo")
                        .HasColumnType("int");

                    b.Property<int>("EntrenadorID")
                        .HasColumnType("int");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EntrenadorID");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("src.Model.Gestion.Membresia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID")
                        .IsUnique();

                    b.ToTable("Membresias");
                });

            modelBuilder.Entity("src.Model.Gestion.Reserva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClaseID")
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClaseID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("src.Model.Inventario.Maquina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("FechaAdquisicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VidaUtilMeses")
                        .HasColumnType("int");

                    b.Property<double>("costo")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Maquinas");
                });

            modelBuilder.Entity("src.Model.Personas.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("ID");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("TipoPersona").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("src.Model.Personas.Cliente", b =>
                {
                    b.HasBaseType("src.Model.Personas.Person");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("src.Model.Personas.Entrenador", b =>
                {
                    b.HasBaseType("src.Model.Personas.Person");

                    b.Property<int>("AñosDeExperiencia")
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorariosDisponibles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Entrenador");
                });

            modelBuilder.Entity("ProyectoGym.src.Model.Finanzas.Factura", b =>
                {
                    b.HasOne("src.Model.Personas.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("src.Model.Gestion.Clase", b =>
                {
                    b.HasOne("src.Model.Personas.Entrenador", "Entrenador")
                        .WithMany("Clases")
                        .HasForeignKey("EntrenadorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrenador");
                });

            modelBuilder.Entity("src.Model.Gestion.Membresia", b =>
                {
                    b.HasOne("src.Model.Personas.Cliente", null)
                        .WithOne("Membresia")
                        .HasForeignKey("src.Model.Gestion.Membresia", "ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("src.Model.Gestion.Reserva", b =>
                {
                    b.HasOne("src.Model.Gestion.Clase", "Clase")
                        .WithMany("Reservas")
                        .HasForeignKey("ClaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Model.Personas.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Clase");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("src.Model.Gestion.Clase", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("src.Model.Personas.Cliente", b =>
                {
                    b.Navigation("Membresia")
                        .IsRequired();

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("src.Model.Personas.Entrenador", b =>
                {
                    b.Navigation("Clases");
                });
#pragma warning restore 612, 618
        }
    }
}
