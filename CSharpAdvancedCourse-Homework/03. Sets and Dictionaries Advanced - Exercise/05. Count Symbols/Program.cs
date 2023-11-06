using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> characterOccurences = new SortedDictionary<char, int>();
            string someText = Console.ReadLine();

            foreach (char character in someText)
            {
                if (!characterOccurences.ContainsKey(character))
                {
                    characterOccurences.Add(character, 1);
                    continue;
                }

                characterOccurences[character]++;
            }

            foreach (var kvp in characterOccurences)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
