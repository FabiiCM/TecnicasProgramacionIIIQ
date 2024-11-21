using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Gestion
{
    public class Reserva
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int ClaseID { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int id, int clienteID, int claseID, DateTime fechaReserva)
        {
            ID = id;
            ClienteID = clienteID;
            ClaseID = claseID;
            FechaReserva = fechaReserva;
        }

        public override string ToString()
        {
            return $"Reserva ID: {ID}, Cliente ID: {ClienteID}, Clase ID: {ClaseID}, Fecha: {FechaReserva.ToShortDateString()}";
        }
    }
}
