using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] setsLength = input.Split(' ');

            HashSet<int> firstSet = new HashSet<int>();
            int firstSetLength = int.Parse(setsLength[0]);
            for (int f = 0; f < firstSetLength; f++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            HashSet<int> secondSet = new HashSet<int>();
            int secondSetLength = int.Parse(setsLength[1]);
            for (int s = 0; s < secondSetLength; s++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            //HashSet<int> resultSet = new HashSet<int>();
            //Queue<int> resultStack = new Queue<int>();
            List<int> resultList = new List<int>();
            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    //resultSet.Add(number);
                    //resultStack.Enqueue(number);
                    resultList.Add(number);
                }
            }

            //Console.WriteLine(string.Join(" ", resultSet));
            //Console.WriteLine(string.Join(" ", resultStack));
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
