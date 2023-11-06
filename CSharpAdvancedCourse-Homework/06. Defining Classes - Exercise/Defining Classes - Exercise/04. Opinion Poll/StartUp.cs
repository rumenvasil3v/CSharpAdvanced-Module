namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Person> people = GetPeopleInformation(numberOfPeople);

            Func<Person, bool> filterFunc = p => p.Age > 30;
            Func<Person, string> orderFunc = p => p.Name;

            var filteredPeople = people.Where(filterFunc).OrderBy(orderFunc).ToList();

            PrintPeople(filteredPeople);
        }

        static List<Person> GetPeopleInformation(int numberOfPeople)
        {
            List<Person> people = new List<Person>();

            for (int n = 0; n < numberOfPeople; n++)
            {
                string[] personInfo = Console
                    .ReadLine()
                    .Split(' ');

                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);

                Person person = new Person(personName, personAge);

                AddPerson(person, people);
            }

            return people;
        }

        static void AddPerson(Person person, List<Person> people)
        {
            people.Add(person);
        }

        static void PrintPeople(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}