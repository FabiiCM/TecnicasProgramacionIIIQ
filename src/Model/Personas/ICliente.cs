// Model/Personas/ICliente.cs
using ProyectoGym.Model.Gestion;

namespace ProyectoGym.Model.Personas
{
    public interface ICliente : IPerson
    {
        Membresia MembresiaActual { get; set; }
        DateTime FechaPagoMensualidad { get; set; }

        bool EsMensualidadProximaAVencer();
    }
}
