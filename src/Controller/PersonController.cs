using Model.Personas;

namespace Controller
{
    /// <summary>
    /// Clase encargada de gestionar la entidad Persona.
    /// </summary>
    public static class PersonController
    {
        /// <summary>
        /// Obtiene una lista de personas.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Person"/> con los datos de las personas.</returns>
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
            };
        }
    }
}
