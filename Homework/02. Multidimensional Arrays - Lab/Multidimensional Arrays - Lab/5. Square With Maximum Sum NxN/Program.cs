/*
 3, 6
1, 2, 3, 4, 5, 6
7, 8, 9, 10, 11, 12
13, 14, 15, 16, 17, 18
 */

using System.Text;

namespace _5._Square_With_Maximum_Sum_NxN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(", ");

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixColumns = int.Parse(matrixArguments[1]);

            int[,] matrix = new int[matrixRows, matrixColumns];

            AddingElementsToMatrix(matrix);

            Console.Write("Read size of square submatrixes in matrix: ");
            int submatrixSize = int.Parse(Console.ReadLine());

            FindBestSubMatrixSum(matrix, submatrixSize);
        }

        static void AddingElementsToMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string element = Console.ReadLine();
                string[] matrixElements = element.Split(", ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(matrixElements[col]);
                }
            }
        }

        static void FindBestSubMatrixSum(int[,] matrix, int submatrixSize)
        {
            long currentSubmatrixSum = 0;

            StringBuilder sb = new StringBuilder();
            long bestSubmatrixSum = long.MinValue; ;
            for (int row = 0; row <= matrix.GetLength(0) - submatrixSize; row++)
            {
                int subMatrixRow = row;

                for (int col = 0; col <= matrix.GetLength(1) - submatrixSize; col++)
                {
                    int subMatrixCol = col;
                    currentSubmatrixSum = SumElementsOfCurrentSubmatrix(matrix, subMatrixCol + submatrixSize, subMatrixRow + submatrixSize, row, col);
                    if (currentSubmatrixSum > bestSubmatrixSum)
                    {
                        AppendBestSubmatrix(sb, matrix, submatrixSize, subMatrixCol, subMatrixRow, row, col);
                        bestSubmatrixSum = currentSubmatrixSum;
                    }
                }
            }

            if (sb.Length > 0)
            {
                Console.Write(sb.ToString());
                Console.WriteLine(bestSubmatrixSum);
            }
        }

        static long SumElementsOfCurrentSubmatrix(int[,] matrix, int subMatrixCol, int submatrixRow, int row, int col)
        {

            long currentSubmatrixSum = 0;

            for (int currentRow = row; currentRow < submatrixRow; currentRow++)
            {
                for (int currentCol = col; currentCol < subMatrixCol; currentCol++)
                {
                    currentSubmatrixSum += matrix[currentRow, currentCol];
                }
            }

            return currentSubmatrixSum;
        }

        static void AppendBestSubmatrix(StringBuilder sb, int[,] matrix, int submatrixSize, int subMatrixCol, int subMatrixRow, int row, int col)
        {
            sb.Clear();

            for (int i = row; i < subMatrixRow + submatrixSize; i++)
            {
                for (int j = col; j < subMatrixCol + submatrixSize; j++)
                {
                    if (j == submatrixSize + subMatrixCol - 1)
                    {
                        sb.AppendLine($"{matrix[i, j]}");
                        break;
                    }
                    sb.Append($"{matrix[i, j]} ");
                }
            }
        }
    }
}