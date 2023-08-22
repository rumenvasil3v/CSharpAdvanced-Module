using System;
using System.Globalization;
using System.Text;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] isleOfTheSnakeMatrixArguments = input.Split(' ');

            string snakeLength = Console.ReadLine();

            int matrixRows = int.Parse(isleOfTheSnakeMatrixArguments[0]);
            int matrixColumns = int.Parse(isleOfTheSnakeMatrixArguments[1]);

            char[,] snakeMatrix = new char[matrixRows, matrixColumns];

            SnakePatternInMatrix(snakeMatrix, snakeLength);
            PrintMatrix(snakeMatrix);
        }

        static void SnakePatternInMatrix(char[,] snakeMatrix, string snakeLength)
        {
            StringBuilder sb = new StringBuilder();

            int currentRow = 0;
            int count = 0;
            sb.Append(snakeLength);
            string text = sb.ToString();

            for (int row = 0; row < snakeMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < snakeMatrix.GetLength(1); col++)
                {
                    snakeMatrix[row, col] = text[col];
                }

                if (count - 1 == snakeLength.Length - snakeMatrix.GetLength(1))
                {
                    currentRow = row;
                    count = 0;
                }

                text = string.Empty;

                if (row % 2 == 0)
                {
                    for (int c = snakeMatrix.GetLength(1) - 1 - (snakeLength.Length - snakeMatrix.GetLength(1) - count); c >= 0; c--)
                    {
                        text += snakeMatrix[currentRow, c];
                    }

                    if (text.Length < snakeMatrix.GetLength(1))
                    {
                        int index = 0;
                        if (text[text.Length - 1] == sb[0])
                        {
                            index = sb.Length - 1;
                        }
                        else
                        {
                            index = sb.Length - 1 - (sb.Length - text.Length);
                        }

                        for (int t = index; t >= 0; t--)
                        {
                            if (text.Length == snakeMatrix.GetLength(1))
                            {
                                break;
                            }

                            text += sb[t];
                        }
                    }

                    
                }
                else if (row % 2 == 1)
                {
                    for (int c = snakeMatrix.GetLength(1) - 1 - (snakeLength.Length - snakeMatrix.GetLength(1) - count); c < snakeMatrix.GetLength(1); c++)
                    {
                        text += snakeMatrix[currentRow, c];
                    }

                    if (text.Length < snakeMatrix.GetLength(1))
                    {
                        for (int t = snakeMatrix.GetLength(1); t < sb.Length; t++)
                        {
                            if (text.Length == snakeMatrix.GetLength(1))
                            {
                                break;
                            }

                            text += sb[t];

                            if (t + 1 == sb.Length)
                            {
                                t = -1;
                            }
                        }
                    }
                }

                count++;
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}