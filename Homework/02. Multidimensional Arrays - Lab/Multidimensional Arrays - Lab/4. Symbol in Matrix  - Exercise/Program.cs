using System.Text;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int matrixRows = squareMatrixSize;
            int matrixColumns = squareMatrixSize;

            char[,] squareMatrix = new char[matrixRows, matrixColumns];
            int[] rowAndColumnOfWillingElement = new int[2];

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string characters = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = characters[col];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            int[] symbolRowCol = new int[2];
            bool isContained = false;
            
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                { 
                    sb.Append(squareMatrix[row, col]);
                    if (sb.ToString().Contains(symbolToFind))
                    {
                        isContained = true;
                        symbolRowCol[0] = row;
                        symbolRowCol[1] = col;
                        break;
                    }
                }

                if (isContained)
                {
                    break;
                }
            }

            if (isContained)
            {
                Console.WriteLine($"({string.Join(", ", symbolRowCol)})");
            }
            else
            {
                Console.WriteLine("{0} does not occur in the matrix", symbolToFind);
            }
        }
    }
}