using System.ComponentModel;
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

            AddingElementsToMatrix(squareMatrix);

            char symbolToFind = char.Parse(Console.ReadLine());
            int[] symbolRowCol = new int[2];
            bool isContained = FindExactSymbol(squareMatrix, symbolToFind, symbolRowCol);

            if (isContained)
            {
                Console.WriteLine($"({string.Join(", ", symbolRowCol)})");
            }
            else
            {
                Console.WriteLine("{0} does not occur in the matrix", symbolToFind);
            }
        }

        static void AddingElementsToMatrix(char[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string characters = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = characters[col];
                }
            }
        }

        static bool FindExactSymbol(char[,] squareMatrix, char symbolToFind, int[] symbolRowCol)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    sb.Append(squareMatrix[row, col]);
                    if (sb.ToString().Contains(symbolToFind))
                    {  
                        symbolRowCol[0] = row;
                        symbolRowCol[1] = col;
                        return true;
                    }
                }  
            }

            return false;
        }
    }
}