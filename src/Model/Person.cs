namespace Model
{

    /// <summary>
    /// Model for Person .
    /// </summary>
    public class Person
    {
        public Person(string name, DateTime birth)
        {
            this.Name = name;
            this.Birthday = birth;
        }

        public string Name { get; set; }



        public DateTime Birthday { get; set; }

    }
}

//prueba de commit
