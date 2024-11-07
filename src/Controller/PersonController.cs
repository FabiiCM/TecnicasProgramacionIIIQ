using Model;

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
            new Person(" Christopher Calvo",  DateTime.Today)
           
        };
            
      }
   }
}
// Prueba   
//prueba