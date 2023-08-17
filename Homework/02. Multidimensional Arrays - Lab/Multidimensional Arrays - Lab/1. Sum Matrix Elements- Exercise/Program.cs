namespace _1._Sum_Matrix_Elements__Exercise
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

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(", ");

                
            }

            Console.WriteLine(sum);
        }
    }
}