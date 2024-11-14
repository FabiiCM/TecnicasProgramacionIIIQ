// Model/Finanzas/Factura.cs
using ProyectoGym.Model.Personas; //para acceder a la clase Cliente
using System;

namespace ProyectoGym.Model.Finanzas
{
    public class Factura
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Monto { get; set; }
    }
}
