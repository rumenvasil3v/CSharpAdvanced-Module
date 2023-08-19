using System;
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
            
        }

        static void PrintMatrix(char[,] matrix)
        {
            
        }
    }
}