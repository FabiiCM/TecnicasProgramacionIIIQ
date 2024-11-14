// Model/Personas/Entrenador.cs
using ProyectoGym.Model.Gestion;
using System;
using System.Collections.Generic;

namespace ProyectoGym.Model.Personas
{
    public class Entrenador : Person
    {
        public Entrenador(int id, string name, string apellido, DateTime birth, string email, string telefono)
            : base(id, name, apellido, birth, email, telefono) // Llama al constructor completo de Person
        {
            ClasesAsignadas = new List<Clase>();
            PuntosFuertes = new List<string>();
        }

        public List<Clase> ClasesAsignadas { get; set; }
        public List<string> PuntosFuertes { get; set; }
    }
}
