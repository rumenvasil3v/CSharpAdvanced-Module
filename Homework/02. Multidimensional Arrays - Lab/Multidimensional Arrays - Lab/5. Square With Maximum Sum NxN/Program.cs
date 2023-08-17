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
    }
}