using ProyectoGym.Model.Personas; // Para acceder a Cliente
using ProyectoGym.Model.Gestion;   // Para acceder a Clase 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model/Gestion/Reserva.cs
namespace ProyectoGym.Model.Gestion
{
    public class Reserva
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Clase ClaseReservada { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
