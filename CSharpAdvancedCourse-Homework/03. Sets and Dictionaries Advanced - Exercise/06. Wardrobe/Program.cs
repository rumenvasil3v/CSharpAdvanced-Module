using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> coloredClothes = new Dictionary<string, Dictionary<string, int>>();
            int numberLinesOfClothes = int.Parse(Console.ReadLine());

            for (int c = 0; c < numberLinesOfClothes; c++)
            {
                string input = Console.ReadLine();
                string[] clothesArguments = input.Split(" -> ");

                string colorOfClothes = clothesArguments[0];
                string[] clothes = clothesArguments[1].Split(',');

                if (!coloredClothes.ContainsKey(colorOfClothes))
                {
                    coloredClothes.Add(colorOfClothes, new Dictionary<string, int>());
                }

                foreach (string garment in clothes)
                {
                    if (!coloredClothes[colorOfClothes].ContainsKey(garment))
                    {
                        coloredClothes[colorOfClothes].Add(garment, 1);
                        continue;
                    }

                    coloredClothes[colorOfClothes][garment]++;
                }
            }

            string colorWithClothe = Console.ReadLine();
            string[] splitColorWithClothe = colorWithClothe.Split(' ');
            string lookingColor = splitColorWithClothe[0];
            string lookingGarment = splitColorWithClothe[1];

            PrintDictionary(coloredClothes, lookingColor, lookingGarment);
        }

        static void PrintDictionary(Dictionary<string, Dictionary<string, int>> coloredClothes, string lookingColor, string lookingGarment)
        {
            foreach (var kvp in coloredClothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var garment in kvp.Value)
                {
                    if (lookingColor == kvp.Key && lookingGarment == garment.Key)
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {garment.Key} - {garment.Value}");
                }
            }
        }
    }
}