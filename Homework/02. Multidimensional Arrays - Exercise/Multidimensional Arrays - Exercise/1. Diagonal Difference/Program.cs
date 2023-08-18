using System;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];

            AddElementsToMatrix(matrix);

            int primaryDiagonal = SumSquareMatrixPrimaryDiagonal(matrix);
            int secondaryDiagonal = SumSquareMatrixSecondaryDiagonal(matrix);

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }

        static void AddElementsToMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(matrixElements[col]);
                }
            }
        }

        static int SumSquareMatrixPrimaryDiagonal(int[,] matrix)
        {
            int primaryDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonalSum += matrix[row, row];
            }

            return primaryDiagonalSum;
        }

        static int SumSquareMatrixSecondaryDiagonal(int[,] matrix)
        {
            int secondaryDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               secondaryDiagonalSum += matrix[row, matrix.GetLength(1) - 1 - row];
            }

            return secondaryDiagonalSum;
        }
    }
}
