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

            int[] rowAndColumnOfWillingElement = new int[2];

            bool isItFalse = FindExactSymbol(squareMatrix, symbolToFind, rowAndColumnOfWillingElement);

            if (isItFalse)
            {
                Console.WriteLine("{0} does not occur in the matrix", symbolToFind);
            }
            else
            {
                Console.WriteLine($"({string.Join(", ", rowAndColumnOfWillingElement)})");
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

        static bool FindExactSymbol(char[,] squareMatrix, char symbolToFind, int[] rowAndColumnOfWillingElement)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (symbolToFind == squareMatrix[row, col])
                    {
                        rowAndColumnOfWillingElement[0] = row;
                        rowAndColumnOfWillingElement[1] = col;                     
                        return false;
                    }
                }
            }

            return true;
        }
    }
}