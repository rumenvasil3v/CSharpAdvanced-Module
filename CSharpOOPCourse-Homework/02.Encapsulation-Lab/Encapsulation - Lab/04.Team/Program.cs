using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new("SoftUni");

            List<Person> players = new();

            int numberOfLines = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfLines; n++)
            {
                string[] personProperties = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personFirstName = personProperties[0];
                string personLastName = personProperties[1];
                int persoAge = int.Parse(personProperties[2]);
                decimal salary = decimal.Parse(personProperties[3]);

                try
                {
                    Person person = new(personFirstName, personLastName, persoAge, salary);
                    players.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var player in players)
            {
                team.AddPlayer(player);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count}.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count}.");
        }
    }
}