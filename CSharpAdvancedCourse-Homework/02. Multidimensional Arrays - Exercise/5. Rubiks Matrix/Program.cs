using System;
namespace _5._Rubiks_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(' ');

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixCols = int.Parse(matrixArguments[1]);

            int[,] matrix = new int[matrixRows, matrixCols];
            AddingElementsToMatrix(matrix);

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfCommands; n++)
            {
                string movement = Console.ReadLine();
                string[] movementArguments = movement.Split(' ');

                int rowOrColToMove = 0;
                int moves = 0;
                switch (movementArguments[1])
                {
                    case "down":
                        rowOrColToMove = int.Parse(movementArguments[0]);
                        moves = int.Parse(movementArguments[2]);
                        MatrixShuffleDown(matrix, moves, rowOrColToMove);
                        break;
                    case "up":
                        rowOrColToMove = int.Parse(movementArguments[0]);
                        moves = int.Parse(movementArguments[2]);
                        MatrixShuffleUp(matrix, moves, rowOrColToMove);
                        break;
                    case "right":
                        rowOrColToMove = int.Parse(movementArguments[0]);
                        moves = int.Parse(movementArguments[2]);
                        MatrixShuffleRight(matrix, moves, rowOrColToMove);
                        break;
                    case "left":
                        rowOrColToMove = int.Parse(movementArguments[0]);
                        moves = int.Parse(movementArguments[2]);
                        MatrixShuffleLeft(matrix, moves, rowOrColToMove);
                        break;
                }  
            }

            RearrangeMatrix(matrix);
        }

        static void MatrixShuffleRight(int[,] matrix, int moves, int row)
        {

            while (moves  % matrix.GetLength(0) > 0)
            {
                int lastNumber = matrix[row, matrix.GetLength(1) - 1];

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentNumber = matrix[row, col];

                    matrix[row, col] = lastNumber;

                    lastNumber = currentNumber;
                }

                moves--;
            }
        }

        static void MatrixShuffleLeft(int[,] matrix, int moves, int row)
        {

            while (moves % matrix.GetLength(0) > 0)
            {
                int firstNumber = matrix[row, 0];

                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    int currentNumber = matrix[row, col];

                    matrix[row, col] = firstNumber;

                    firstNumber = currentNumber;
                }

                moves--;
            }
        }

        static void AddingElementsToMatrix(int[,] matrix)
        {
            int number = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number++;
                }
            }
        }

        static void MatrixShuffleDown(int[,] matrix, int moves, int col)
        {
            while (moves % matrix.GetLength(1) > 0)
            {
                int lastNumber = matrix[matrix.GetLength(0) - 1, col];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int currentNumber = matrix[row, col];

                    matrix[row, col] = lastNumber;

                    lastNumber = currentNumber;
                }

                moves--;
            }
        }

        static void MatrixShuffleUp(int[,] matrix, int moves, int col)
        {

            while (moves % matrix.GetLength(1) > 0)
            {
                int firstNumber = matrix[0, col];

                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    int currentNumber = matrix[row, col];

                    matrix[row, col] = firstNumber;

                    firstNumber = currentNumber;
                }

                moves--;
            }
        }

        static void RearrangeMatrix(int[,] matrix)
        {
            int number = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int currentRow = row;
                        int currentCol = col;
                        int currentNumber = matrix[currentRow, currentCol];

                        int rowToSwap = 0;
                        int colToSwap = 0;
                        bool swap = false;

                        for (int r = 0; r < matrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < matrix.GetLength(1); c++)
                            {
                                if (matrix[r, c] == number)
                                {
                                    rowToSwap = r;
                                    colToSwap = c;
                                    swap = true;
                                    break;
                                }
                            }

                            if (swap)
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"Swap ({currentRow}, {currentCol}) with ({rowToSwap}, {colToSwap})");
                        matrix[currentRow, currentCol] = number;
                        matrix[rowToSwap, colToSwap] = currentNumber;
                    }

                    number++;
                }
            }
        }
    }
}
