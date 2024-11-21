namespace Model.Personas
{

    /// <summary>
    /// Model for Person .
    /// </summary>
    public class Person
    {
        public Person(string name, DateTime birth)
        {
            Name = name;
            Birthday = birth;
        }

        public string Name { get; set; }



        public DateTime Birthday { get; set; }

    }
}

