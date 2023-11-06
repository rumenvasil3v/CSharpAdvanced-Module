/*
5 7
a a b c a d i
a a m m i s w
b b m m i S w
k l o p p e q
n b z x y u t
 */

using System;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] matrixArguments = input.Split(' ');

            int matrixRows = Math.Abs(int.Parse(matrixArguments[0]));
            int matrixColumns = Math.Abs(int.Parse(matrixArguments[1]));

            char[,] matrix = new char[matrixRows, matrixColumns];
            AddElementsToMatrix(matrix);

            FindSameCharactersInSquareSubmatrix(matrix);
        }

        static void AddElementsToMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(matrixElements[col]);
                }
            }
        }

        static void FindSameCharactersInSquareSubmatrix(char[,] matrix)
        {
            int countOfEqualSubmatrixCharacters = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
                {
                    char firstChar = matrix[row, col];
                    char secondChar = matrix[row, col + 1];
                    char thirdChar = matrix[row + 1, col];
                    char fourthChar = matrix[row + 1, col + 1];

                    if (firstChar == secondChar && firstChar == thirdChar && firstChar == fourthChar)
                    {
                        countOfEqualSubmatrixCharacters++;
                    }
                }
            }

            Console.WriteLine(countOfEqualSubmatrixCharacters);
        }
    }
}
