/*
4
1 1 1 1 1 1
2 1 1 3
2 1 1 2 3
7 7 7 5 3 2
1 1
2 2 2 3
3 3 3
4 4
 */

using System;
using System.Linq;

namespace _7._Lego_Blocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] firstJaggedArray = new int[numberOfRows][];
            int[][] secondJaggedArray = new int[numberOfRows][];

            AddingElementsToFirstJaggedArray(firstJaggedArray);
            AddingElementsToSecondJaggedArray(secondJaggedArray);

            ReverseElementsOfSecondJaggedArray(secondJaggedArray);
            PrintWhetherArrayFitsOrNot(firstJaggedArray, secondJaggedArray, numberOfRows);
        }

        static void ReverseElementsOfSecondJaggedArray(int[][] secondJaggedArray)
        {
            for (int r = 0; r < secondJaggedArray.Length; r++)
            {
                Array.Reverse(secondJaggedArray[r]);
            }
        }

        static void PrintWhetherArrayFitsOrNot(int[][] firstJaggedArray, int[][] secondJaggedArray, int numberOfRows)
        {
            int fittingValue = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
            bool isItFit = false;
            for (int m = 0; m < numberOfRows; m++)
            {
                if (fittingValue == firstJaggedArray[m].Length + secondJaggedArray[m].Length)
                {
                    isItFit = true;
                }
                else
                {
                    isItFit = false;
                    break;
                }
            }

            if (isItFit)
            {
                int[][] jaggedResult = new int[numberOfRows][];

                for (int row = 0; row < numberOfRows; row++)
                {
                    int count = 0;
                    jaggedResult[row] = new int[fittingValue];

                    for (int firstCol = 0; firstCol < firstJaggedArray[row].Length; firstCol++)
                    {
                        jaggedResult[row][count++] = firstJaggedArray[row][firstCol];
                    }

                    for (int secondCol = 0; secondCol < secondJaggedArray[row].Length; secondCol++)
                    {
                        jaggedResult[row][count++] = secondJaggedArray[row][secondCol];
                    }
                }

                for (int r = 0; r < jaggedResult.Length; r++)
                {
                    Console.WriteLine($"[{string.Join(", ", jaggedResult[r])}]");
                }
            }
            else
            {
                int totalCells = 0;
                for (int a = 0; a < numberOfRows; a++)
                {
                    totalCells += firstJaggedArray[a].Length + secondJaggedArray[a].Length;
                }

                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
        }

        static void AddingElementsToFirstJaggedArray(int[][] firstJaggedArray)
        {
            for (int firstRow = 0; firstRow < firstJaggedArray.Length; firstRow++)
            {
                string firstElements = Console.ReadLine();
                string[] firstJaggedArrayElements = firstElements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                firstJaggedArray[firstRow] = new int[firstJaggedArrayElements.Length];

                for (int firstCol = 0; firstCol < firstJaggedArray[firstRow].Length; firstCol++)
                {
                    firstJaggedArray[firstRow][firstCol] = int.Parse(firstJaggedArrayElements[firstCol]);
                }
            }
        }

        static void AddingElementsToSecondJaggedArray(int[][] secondJaggedArray)
        {
            for (int secondRow = 0; secondRow < secondJaggedArray.Length; secondRow++)
            {
                string seconfElements = Console.ReadLine();
                string[] secondJaggedArrayElements = seconfElements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                secondJaggedArray[secondRow] = new int[secondJaggedArrayElements.Length];

                for (int secondCol = 0; secondCol < secondJaggedArray[secondRow].Length; secondCol++)
                {
                    secondJaggedArray[secondRow][secondCol] = int.Parse(secondJaggedArrayElements[secondCol]);
                }
            }
        }
    }
}
