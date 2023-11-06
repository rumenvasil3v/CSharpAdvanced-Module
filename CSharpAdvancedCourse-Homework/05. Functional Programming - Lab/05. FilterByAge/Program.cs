namespace _05._FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            if (condition == "older")
            {
                people = people.Where(x => x.Age >= ageThreshold).ToList();
            }
            else if (condition == "younger")
            {
                people = people.Where(x => x.Age < ageThreshold).ToList();
            }

            string format = Console.ReadLine();
            List<string> output = new List<string>();
            switch (format)
            {
                case "name age":
                    output = people.Select(x => $"{x.Name} - {x.Age}").ToList();
                    break;
                case "age":
                    output = people.Select(x => $"{x.Age}").ToList();
                    break;
                case "name":
                    output = people.Select(x => $"{x.Name}").ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, output));
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