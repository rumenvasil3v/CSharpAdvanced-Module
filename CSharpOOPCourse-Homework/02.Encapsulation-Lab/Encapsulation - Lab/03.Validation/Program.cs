using System;

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
                decimal salary = decimal.Parse(personProperties[3]);

                try
                {
                    Person person = new(personFirstName, personLastName, persoAge, salary);
                    people.Add(person);
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine(argumentException.Message);
                }
            }

            decimal percentageBonusToSalary = decimal.Parse(Console.ReadLine());

            foreach (var person in people)
            {
                person.IncreaseSalary(percentageBonusToSalary);
                Console.WriteLine(person.ToString());
            }
        }
    }
}
