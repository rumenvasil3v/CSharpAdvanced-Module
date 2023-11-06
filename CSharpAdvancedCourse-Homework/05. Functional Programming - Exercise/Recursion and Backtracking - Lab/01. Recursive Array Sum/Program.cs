using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            int[] numbers = splittedInput.Select(int.Parse).ToArray();

            int result = SumRecursivelyElementsOfArray(numbers, 0);
            Console.WriteLine(result);
        }

        static int SumRecursivelyElementsOfArray(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + SumRecursivelyElementsOfArray(numbers, index + 1);
        }
    }
}