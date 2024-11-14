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
