using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model/Gestion/IMembresia.cs
namespace ProyectoGym.Model.Gestion
{
    public interface IMembresia
    {
        int Id { get; set; }
        string Tipo { get; set; }
        decimal Costo { get; set; }
        bool Activa { get; set; }
    }
}
