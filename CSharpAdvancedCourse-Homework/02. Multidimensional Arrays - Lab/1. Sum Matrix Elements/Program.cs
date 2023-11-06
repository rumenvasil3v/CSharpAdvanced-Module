namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT    
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(", ");
      
            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixColumns = int.Parse(matrixArguments[1]);

            // 3[rows], 6[columns]
            int[,] matrix = new int[matrixRows, matrixColumns];

            // CODE LOGIC
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               sum = AddingElementsToEveryRow(matrix, row, sum);
            }

            // OUTPUT
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }

        static int AddingElementsToEveryRow(int[,] matrix, int row, int sum)
        {
            string elements = Console.ReadLine();
            string[] matrixElements = elements.Split(", ");

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(matrixElements[col]);
                sum += matrix[row, col];
            }

            return sum;
        }
    }
}