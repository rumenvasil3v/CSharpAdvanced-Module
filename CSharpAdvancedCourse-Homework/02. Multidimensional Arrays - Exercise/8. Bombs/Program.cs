/*
4
8 3 2 5
6 4 7 9
9 9 3 6
6 8 1 2
1,2 2,1 2,0

3
5 5 5
5 5 5
7 7 7
1,1 1,2
 */

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int matrixRows = int.Parse(input);
            int matrixCols = int.Parse(input);

            int[,] matrix = new int[matrixRows, matrixCols];

            AddingElementsToMatrix(matrix);

            string coordinates = Console.ReadLine();
            string[] bombs = coordinates.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int b = 0; b < bombs.Length; b++)
            {
                string[] bombArguments = bombs[b].Split(',', StringSplitOptions.RemoveEmptyEntries);

                int bombRow = int.Parse(bombArguments[0]);
                int bombCol = int.Parse(bombArguments[1]);

                int valueOfBomb = matrix[bombRow, bombCol];

                if (valueOfBomb > 0)
                {
                    if (IsInside(matrix, bombRow, bombCol - 1) && matrix[bombRow, bombCol - 1] > 0)
                    {
                        matrix[bombRow, bombCol - 1] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow, bombCol + 1) && matrix[bombRow, bombCol + 1] > 0)
                    {
                        matrix[bombRow, bombCol + 1] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow - 1, bombCol + 1) && matrix[bombRow - 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol + 1] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow - 1, bombCol - 1) && matrix[bombRow - 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol - 1] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow - 1, bombCol) && matrix[bombRow - 1, bombCol] > 0)
                    {
                        matrix[bombRow - 1, bombCol] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow + 1, bombCol) && matrix[bombRow + 1, bombCol] > 0)
                    {
                        matrix[bombRow + 1, bombCol] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow + 1, bombCol + 1) && matrix[bombRow + 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol + 1] -= valueOfBomb;
                    }

                    if (IsInside(matrix, bombRow + 1, bombCol - 1) && matrix[bombRow + 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol - 1] -= valueOfBomb;
                    }

                    matrix[bombRow, bombCol] = 0;
                }
            }

            PrintMatrix(matrix);
        }

        static void AddingElementsToMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(matrixElements[col]);
                }
            }
        }

        static bool IsInside(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int countOfAliveCells = 0;
            double sumOfAliveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        countOfAliveCells++;
                        sumOfAliveCells += matrix[row, col];
                    }
                }
            }

            Console.WriteLine("Alive cells: {0}", countOfAliveCells);
            Console.WriteLine("Sum: {0}", sumOfAliveCells);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}