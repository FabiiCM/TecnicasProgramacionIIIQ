using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model/Gestion/Membresia.cs
namespace ProyectoGym.Model.Gestion
{
    public class Membresia : IMembresia
    {
        public int Id { get; set; }
        public string Tipo { get; set; }  // Ej: Mensual, Anual...
        public decimal Costo { get; set; }
        public bool Activa { get; set; }
    }
}