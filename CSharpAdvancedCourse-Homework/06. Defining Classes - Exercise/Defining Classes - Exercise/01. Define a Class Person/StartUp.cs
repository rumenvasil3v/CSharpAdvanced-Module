namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person() { Name = "Peter", Age = 20};
            Person george = new Person() { Name = "George", Age = 18 };
            Person jose = new Person() { Name = "Jose", Age = 43 };

            List<Person> people = new List<Person>() { peter, george, jose };

            foreach (Person person in people)
            {
                Console.WriteLine($"Person Name: {person.Name}; Age: {person.Age}");
            }
        }
    }
}