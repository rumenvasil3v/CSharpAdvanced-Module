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

            StringBuilder sb = new StringBuilder();
            foreach (var ch in squareMatrix)
            {
                sb.Append(ch);
            }

            if (sb.ToString().Contains(symbolToFind))
            {

            }
            else
            {
                Console.WriteLine("{0} does not occur in the matrix", symbolToFind);
            }
        }
    }
}