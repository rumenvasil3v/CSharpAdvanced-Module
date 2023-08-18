/*
 2 3
1 2 3
4 5 6
swap 0 0 1 3 4
swap 0 0 1 1
swap 10 9 8 7
swap 0 1 1 0
END
 */


using System;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] matrixArguments = input.Split(' ');

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixColumns = int.Parse(matrixArguments[1]);

            string[,] matrix = new string[matrixRows, matrixColumns];

            AddElementsToMatrix(matrix);
            SwapElementsInMatrix(matrix);
        }

        static void AddElementsToMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
            }
        }

        static void SwapElementsInMatrix(string[,] matrix)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArguments = command.Split(' ');

                switch (commandArguments[0])
                {
                    case "swap":
                        if (commandArguments.Length < 5 || commandArguments.Length > 5)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        int firstRow = int.Parse(commandArguments[1]);
                        int firstCol = int.Parse(commandArguments[2]);

                        int secondRow = int.Parse(commandArguments[3]);
                        int secondCol = int.Parse(commandArguments[4]);

                        if (firstRow < 0 || firstCol < 0 || secondRow < 0 || secondCol < 0
                            || firstRow >= matrix.GetLength(0) || firstCol >= matrix.GetLength(1)
                            || secondRow >= matrix.GetLength(0) || secondCol >= matrix.GetLength(1))
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string elementAtFirstRowAndCol = matrix[firstRow, firstCol];
                            matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                            matrix[secondRow, secondCol] = elementAtFirstRowAndCol;

                            PrintCurrentConditionOfMatrix(matrix);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }

        static void PrintCurrentConditionOfMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
