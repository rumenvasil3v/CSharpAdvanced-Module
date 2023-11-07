namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new();

            int numberOfLines = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfLines; n++)
            {
                string[] personProperties = Console
                    .ReadLine()
                    .Split(" ");

                string personFirstName = personProperties[0];
                string personLastName = personProperties[1];
                int persoAge = int.Parse(personProperties[2]);

                Person person = new(personFirstName, personLastName, persoAge);

                people.Add(person);
            }

            foreach (var person in people.OrderBy(x => x.FirstName).ThenBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}