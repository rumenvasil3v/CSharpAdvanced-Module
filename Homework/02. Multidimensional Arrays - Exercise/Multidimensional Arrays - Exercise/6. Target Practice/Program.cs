using System;

namespace _6._Target_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(' ');

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixCols = int.Parse(matrixArguments[1]);

            char[,] matrix = new char[matrixRows, matrixCols];
            AddingElementsToMatrix(matrix);

            PrintMatrix(matrix);

            DestroySnake(matrix);

            PrintMatrix(matrix);

            MoveSymbols(matrix);

            PrintMatrix(matrix);
        }

        static void MoveSymbols(char[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == ' ')
                    {
                        int bestSpace = FindBestSpace(matrix, col);

                        for (int r = bestSpace; r >= 0; r--)
                        {
                            if (r == 0)
                            {
                                break;
                            }

                            char currentCharacter = matrix[r - 1, col];
                            matrix[r, col] = currentCharacter;
                            matrix[r - 1, col] = ' ';
                        }

                        Console.WriteLine();
                        PrintMatrix(matrix);
                    }
                }
            }
        }

        static int FindBestSpace(char[,] matrix, int col)
        {
            int best = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                if (matrix[row, col] == ' ')
                {
                    int currentSpaceRow = row;

                    if (currentSpaceRow > best)
                    {
                        best = currentSpaceRow;
                    }
                }
            }

            return best;
        }

        static void DestroySnake(char[,] matrix)
        {
            string coordinates = Console.ReadLine();
            string[] matrixCoordinates = coordinates.Split(" ");

            int targetRow = int.Parse(matrixCoordinates[0]);
            int targetCol = int.Parse(matrixCoordinates[1]);
            int radius = int.Parse(matrixCoordinates[2]);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int dr = targetRow - row;
                    int dc = targetCol - col;

                    if (dr * dr + dc * dc <= radius * radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static void AddingElementsToMatrix(char[,] matrix)
        {
            bool rightToLeft = true;
            bool leftToRight = false;

            string snake = Console.ReadLine();
            int count = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (rightToLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[count++];

                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }

                    rightToLeft = false;
                    leftToRight = true;
                }
                else if (leftToRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[count++];

                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }

                    rightToLeft = true;
                    leftToRight = false;
                }
            }
        }

    }
}
