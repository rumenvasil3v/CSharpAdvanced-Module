using System.Text;

namespace _5._Square_With_Maximum_Sum
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

            FindBestSubMatrixSum(matrix);
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

        static void FindBestSubMatrixSum(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            long bestSubmatrixSum = long.MinValue; ;
            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
                {
                    long currentSubmatrixSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSubmatrixSum > bestSubmatrixSum)
                    {
                        bestSubmatrixSum = AppendBestSubMatrix(sb, matrix, row, col, bestSubmatrixSum, currentSubmatrixSum);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine(bestSubmatrixSum);
        }

        static long AppendBestSubMatrix(StringBuilder sb, int[,] matrix, int row, int col, long bestSubmatrixSum, long currentSubmatrixSum)
        {
            sb.Clear();

            sb.AppendLine($"{matrix[row, col]} {matrix[row, col + 1]}");
            sb.Append($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}");
            bestSubmatrixSum = currentSubmatrixSum;

            return bestSubmatrixSum;
        }
    }
}