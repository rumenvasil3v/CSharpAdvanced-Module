using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberEvenOccurences = new Dictionary<int, int>();
            int countOfNumbers = int.Parse(Console.ReadLine());

            for (int n = 0; n < countOfNumbers; n++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!numberEvenOccurences.ContainsKey(currentNumber))
                {
                    numberEvenOccurences.Add(currentNumber, 1);
                    continue;
                }

                numberEvenOccurences[currentNumber]++;
            }

            foreach (var occurences in numberEvenOccurences)
            {
                if (occurences.Value % 2 == 0)
                {
                    Console.WriteLine(occurences.Key);
                    break;
                }
            }
        }
    }
}