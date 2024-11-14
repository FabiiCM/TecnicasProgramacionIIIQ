// Model/Personas/Person.cs
namespace ProyectoGym.Model.Personas
{
    /// <summary>
    /// Model for Person.
    /// </summary>
    public class Person : IPerson
    {

        public Person(int id, string nombre, string apellido, DateTime fechaNacimiento,
            string email, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Email = email;
            Telefono = telefono;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
