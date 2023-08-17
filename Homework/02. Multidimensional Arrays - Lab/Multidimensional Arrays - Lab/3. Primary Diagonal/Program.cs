/*
4
1 2 4 7
4 5 6 3
1 8 1 2
3 5 8 9

 */

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int matrixRows = squareMatrixSize;
            int matrixColumns = squareMatrixSize;

            int[,] squareMatrix = new int[matrixRows, matrixColumns];

            AddingElementsToSquareMatrix(squareMatrix);

            SumPrimaryDiagonalOfSquareMatrix(squareMatrix);
        }

        static void AddingElementsToSquareMatrix(int[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = int.Parse(matrixElements[col]);
                }
            }
        }

        static void SumPrimaryDiagonalOfSquareMatrix(int[,] squareMatrix)
        {
            int primaryDiagonalSum = 0;
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                primaryDiagonalSum += squareMatrix[row, row];
            }

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}