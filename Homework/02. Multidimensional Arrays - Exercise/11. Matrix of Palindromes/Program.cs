using System;

namespace _11._Matrix_of_Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split();

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixCols = int.Parse(matrixArguments[1]);

            string[,] matrix = new string[matrixRows, matrixCols];

            AddingElementsToMatrix(matrix);
            PrintMatrix(matrix);
        }

        static void AddingElementsToMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char firstLastCharacter = (char)(97 + row);
                char middleCharacter = (char)(97 + row);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string text = firstLastCharacter.ToString() + middleCharacter.ToString() + firstLastCharacter.ToString();

                    matrix[row, col] = text;

                    middleCharacter = (char)(97 + col + 1 + row);
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
