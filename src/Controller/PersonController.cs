using ProyectoGym.Model.Personas;

namespace Controller
{
    /// <summary>
    /// Class in charge of managing the Person entity.
    /// </summary>
    public static class PersonController
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
            new (123,"Maria","Perez",new DateTime (1999,1,1),"maria@gmail.com","")
        };

        }
    }
}
