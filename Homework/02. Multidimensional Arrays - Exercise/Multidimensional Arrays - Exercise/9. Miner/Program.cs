using System.ComponentModel;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input square matrix
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            //AddingElementsToMatrix(matrix);
            int countOfCoals = 0;
            int minerRow = 0;
            int minerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        countOfCoals++;
                    }

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                }
            }

            string[] directions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            foreach (string direction in directions)
            {

            }
        }

        static void AddingElementsToMatrix(char[,] matrix)
        {
            
        }
    }
}