using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Gestion
{
    public class Membresia
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Costo { get; set; }

        public Membresia(int id, int clienteID, DateTime fechaInicio, DateTime fechaVencimiento, decimal costo)
        {
            ID = id;
            ClienteID = clienteID;
            FechaInicio = fechaInicio;
            FechaVencimiento = fechaVencimiento;
            Costo = costo;
        }

        public bool EstaPorVencer()
        {
            return (FechaVencimiento - DateTime.Now).TotalDays <= 5;
        }

        public override string ToString()
        {
            return $"Membresía ID: {ID}, Cliente ID: {ClienteID}, Vence el: {FechaVencimiento.ToShortDateString()}, Costo: {Costo:C}";
        }
    }
}
