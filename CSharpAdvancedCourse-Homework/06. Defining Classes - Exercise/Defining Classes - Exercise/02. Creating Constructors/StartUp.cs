namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person randomPerson = new Person();
            Person dimitrichko = new Person(20);
            Person viktor = new Person("Viktor Dakov", 29);

            List<Person> people = new List<Person>() { randomPerson, dimitrichko,  viktor };

            foreach (Person person in people)
            {
                Console.WriteLine("Person Name: {0}", person.Name);
                Console.WriteLine("Person Age: {0}", person.Age);

                Console.WriteLine();
            }
        }
    }
}