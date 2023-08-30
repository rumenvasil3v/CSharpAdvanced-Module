using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> compounds = new HashSet<string>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfLines; n++)
            {
                string input = Console.ReadLine();
                string[] chemicalCompounds = input.Split(' ');

                foreach (string chemicalElement in chemicalCompounds)
                {
                    compounds.Add(chemicalElement);
                }
            }

            Console.WriteLine(string.Join(" ", compounds.OrderBy(x => x)));
        }
    }
}
