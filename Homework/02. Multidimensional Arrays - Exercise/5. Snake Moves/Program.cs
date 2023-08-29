using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] isleOfTheSnakeMatrixArguments = input.Split(' ');

            string snakeLength = Console.ReadLine();

            int matrixRows = int.Parse(isleOfTheSnakeMatrixArguments[0]);
            int matrixColumns = int.Parse(isleOfTheSnakeMatrixArguments[1]);

            char[,] snakeMatrix = new char[matrixRows, matrixColumns];

            SnakePatternInMatrix(snakeMatrix, snakeLength);
            PrintMatrix(snakeMatrix);
        }

        static void SnakePatternInMatrix(char[,] snakeMatrix, string snakeLength)
        {
            StringBuilder sb = new StringBuilder();

            int count = 0;
            sb.Append(snakeLength);

            for (int row = 0; row < snakeMatrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < snakeMatrix.GetLength(1); col++)
                    {
                        snakeMatrix[row, col] = sb[count++];

                        if (count == snakeLength.Length)
                        {
                            count = 0;
                        }
                    }
                }
                
                if (row % 2 == 1)
                {
                    for (int col = snakeMatrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        snakeMatrix[row, col] = sb[count++];

                        if (count == snakeLength.Length)
                        {
                            count = 0;
                        }
                    }
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}