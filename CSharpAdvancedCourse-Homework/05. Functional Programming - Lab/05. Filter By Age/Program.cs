using System.Globalization;
using System.Runtime.InteropServices;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = AddingPeople();
            FilterPeople(people);
        }

        static Dictionary<string, int> AddingPeople()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            int number = int.Parse(Console.ReadLine());
            for (int n = 0; n < number; n++)
            {
                string input = Console.ReadLine();
                string[] personArguments = input.Split(", ");

                if (!people.ContainsKey(personArguments[0]))
                {
                    people.Add(personArguments[0], int.Parse(personArguments[1]));
                }
            }

            return people;
        }

        static void FilterPeople(Dictionary<string, int> people)
        {
            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());

            Func<KeyValuePair<string, int>, bool> func = x => true;
            if (condition == "younger")
            {
                func = x => x.Value < ageThreshold;
            }
            else if (condition == "older")
            {
                func = x => x.Value >= ageThreshold;
            }

            Dictionary<string, int> filteredPeople = people.Where(func).ToDictionary(x => x.Key, y => y.Value);
            PrintFilteredPeople(filteredPeople);
        }

        static void PrintFilteredPeople(Dictionary<string, int> people)
        {
            string format = Console.ReadLine();

            switch (format)
            {
                case "name age":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                    break;
                case "name":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Key}");
                    }
                    break;
                case "age":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Value}");
                    }
                    break;
            }
        }
    }
}