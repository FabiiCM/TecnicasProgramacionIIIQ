// Model/Personas/Entrenador.cs
using ProyectoGym.Model.Gestion;

namespace ProyectoGym.Model.Personas
{
    public class Entrenador : Person
    {
        public Entrenador(int id, string name, string apellido, DateTime birth, string email, string telefono)
            : base(id, name, apellido, birth, email, telefono) // Llama al constructor completo de Person
        {
            ClasesAsignadas = [];
            PuntosFuertes = [];
        }

        public List<Clase> ClasesAsignadas { get; set; }
        public List<string> PuntosFuertes { get; set; }
    }
}
