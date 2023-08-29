using System;
using System.Text;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(' ');

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixColumns = int.Parse(matrixArguments[1]);

            int[,] matrix = new int[matrixRows, matrixColumns];

            AddElementsToMatrix(matrix);

            FindBestSubmatrixSum(matrix);
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

        static void FindBestSubmatrixSum(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            long bestSubmatrixSum = long.MinValue;
            
            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    long currentSubmatrixSum = SumCurrentSubmatrix(matrix, row, col);
                    
                    if (currentSubmatrixSum > bestSubmatrixSum)
                    {
                        AppendBestSubmatrix(sb, matrix, row, col);
                        bestSubmatrixSum = currentSubmatrixSum;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", bestSubmatrixSum);
            Console.WriteLine(sb.ToString());
        }

        static long SumCurrentSubmatrix(int[,] matrix, int row, int col)
        {
            long currentSubmatrixSum = 0;

            for (int r = row; r < 3 + row; r++)
            {
                for (int c = col; c < 3 + col; c++)
                {
                    currentSubmatrixSum += matrix[r, c];
                }
            }

            return currentSubmatrixSum;
        }

        static void AppendBestSubmatrix(StringBuilder sb, int[,] matrix, int row, int col)
        {
            sb.Clear();

            for (int r = row; r < 3 + row; r++)
            {
                for (int c = col; c < 3 + col; c++)
                {
                    if (c == 3 + col - 1)
                    {
                        sb.AppendLine($"{matrix[r, c]}");
                        break;
                    }

                    sb.Append($"{matrix[r, c]} ");
                }
            }
        }
    }
}
