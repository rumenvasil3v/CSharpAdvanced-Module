using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(new char[] { ' ' });

            List<int> numbers = inputNumbers.Select(int.Parse).ToList();

            numbers = numbers.OrderBy(x => x).ToList();

            Stack<int> stack = new Stack<int>(numbers);

            //for (int n = 0; n < 3; n++)
            //{
            //    if (stack.Count == 0)
            //    {
            //        break;
            //    }
            //    Console.Write($"{stack.Pop()} ");
            //}

            int n = 3;
            while (n > 0)
            {
                if (stack.Count == 0)
                {
                    break;
                }
                Console.Write($"{stack.Pop()} ");
                n--;
            }
        }
    }
}
