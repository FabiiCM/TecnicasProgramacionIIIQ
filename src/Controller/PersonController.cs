using ProyectoGym.Model.Personas;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            new Person(1123,"Martin","uiboaid",12,"uid@gmail.com","8888")
        };
            
      }
   }
}
// Prueba   
//prueba