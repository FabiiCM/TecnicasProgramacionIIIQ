using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model/Personas/IPerson.cs
namespace ProyectoGym.Model.Personas
{
    public interface IPerson
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DateTime FechaNacimiento { get; set; }
        string Email { get; set; }
        string Telefono { get; set; }
    }
}
