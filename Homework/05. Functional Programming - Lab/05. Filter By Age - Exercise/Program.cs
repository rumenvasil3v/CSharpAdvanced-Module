using System.Threading.Channels;

namespace _05._Filter_By_Age___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);

            string format = Console.ReadLine();
            Action<Person> printer = CreatePrinter(format);

            PrintFilteredPeople(people, filter, printer);
        }

        static List<Person> ReadPeople()
        {
            var people = new List<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfPeople; n++)
            {
                string[] peopleArguments = Console.ReadLine().Split(", ");

                var person = new Person(peopleArguments[0], int.Parse(peopleArguments[1]));
                people.Add(person);
            }

            return people;
        }

        static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "older")
            {
                return x => x.Age >= ageThreshold;
            }
            else
            {
                return x => x.Age < ageThreshold;
            }
        }

        static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name age":
                    return x => Console.WriteLine($"{x.Name} - {x.Age}");
                case "name":
                    return x => Console.WriteLine(x.Name);
                case "age":
                    return x => Console.WriteLine(x.Age);
            }

            return x => Console.WriteLine("Invalid input for {0}", x);
        }

        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            List<Person> filteredPeople = people.Where(filter).ToList();
            foreach (var person in filteredPeople)
            {
                printer(person);
            }
        }
    }

    public class Person
    {

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}