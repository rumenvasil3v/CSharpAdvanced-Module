using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Group_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(", ");

            int[] numbers = text.Select(int.Parse).ToArray();

            GetCountOfRemainders(numbers);
        }

        static void GetCountOfRemainders(int[] numbers)
        {
            int[] countOfRemainders = new int[3];

            foreach (int number in numbers)
            {
                if (Math.Abs(number) % 3 == 0)
                {
                    countOfRemainders[0]++;
                }
                else if (Math.Abs(number) % 3 == 1)
                {
                    countOfRemainders[1]++;
                }
                else if (Math.Abs(number) % 3 == 2)
                {
                    countOfRemainders[2]++;
                }
            }

            AllocateNumbers(countOfRemainders, numbers);
        }

        static void AllocateNumbers(int[] countOfRemainders, int[] numbers)
        {
            int[][] jaggedArray = new int[3][];
            int indexesZeroRemainder = 0;
            int indexesOneRemainder = 0;
            int indexesTwoRemainder = 0;

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new int[countOfRemainders[row]];
            }

            foreach (int number in numbers)
            {
                if (Math.Abs(number) % 3 == 0)
                {
                    jaggedArray[0][indexesZeroRemainder++] = number;
                }
                else if (Math.Abs(number) % 3 == 1)
                {
                    jaggedArray[1][indexesOneRemainder++] = number;
                }
                else if (Math.Abs(number) % 3 == 2)
                {
                    jaggedArray[2][indexesTwoRemainder++] = number;
                }
            }

            PrintJaggedArray(jaggedArray);
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(' ', jaggedArray[row]));
            }
        }
    }
}