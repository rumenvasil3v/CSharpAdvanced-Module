using System;
using System.Globalization;
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

            char[,] isleOfTheSnakeMatrix = new char[matrixRows, matrixColumns];

            SnakePatternInMatrix(isleOfTheSnakeMatrix, snakeLength);
            PrintMatrix(isleOfTheSnakeMatrix);
        }

        static void SnakePatternInMatrix(char[,] isleOfTheSnakeMatrix, string snakeLength)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb2.Append(snakeLength);
            sb.Append(snakeLength);

          
            
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