// Model/Personas/Cliente.cs
using ProyectoGym.Model.Gestion;

namespace ProyectoGym.Model.Personas
{
    public class Cliente : Person, ICliente
    {
        public Cliente(int id, string name, string apellido, DateTime birth, string email, string telefono)
            : base(id, name, apellido, birth, email, telefono) // Llama al constructor completo de Person
        {
            MembresiaActual = null;
            FechaPagoMensualidad = DateTime.Now;
        }

        public Membresia MembresiaActual { get; set; }
        public DateTime FechaPagoMensualidad { get; set; }

        // Método para verificar si la membresía está próxima a vencer
        public bool EsMensualidadProximaAVencer()
        {
            return (FechaPagoMensualidad - DateTime.Now).Days <= 5;
        }
    }
}
