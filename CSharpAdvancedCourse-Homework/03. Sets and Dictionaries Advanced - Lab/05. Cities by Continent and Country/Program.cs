using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int numberOfCountries = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfCountries; n++)
            {
                string input = Console.ReadLine();
                string[] countryArguments = input.Split(' ');

                string continent = countryArguments[0];
                string country = countryArguments[1];
                string countryCity = countryArguments[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>() { { country, new List<string>() } });
                    continents[continent][country].Add(countryCity);
                    continue;
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>() { countryCity });
                    continue;
                }

                continents[continent][country].Add(countryCity);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
