using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> realNumbersOccurences = new Dictionary<double, int>();

            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            double[] numbers = inputNumbers.Select(double.Parse).ToArray();

            IterateThroughNumbers(numbers, realNumbersOccurences);
            PrintDictionary(realNumbersOccurences);
        }

        static void PrintDictionary(Dictionary<double, int> realNumbersOccurences)
        {
            foreach (KeyValuePair<double, int> kvp in realNumbersOccurences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }

        static void IterateThroughNumbers(double[] numbers, Dictionary<double, int> realNumberOccurences)
        {
            for (int n = 0; n < numbers.Length; n++)
            {
                double currentNumber = numbers[n];

                if (!realNumberOccurences.ContainsKey(currentNumber))
                {
                    realNumberOccurences.Add(currentNumber, 1);
                    continue;
                }

                realNumberOccurences[currentNumber]++;
            }
        }
    }
}
