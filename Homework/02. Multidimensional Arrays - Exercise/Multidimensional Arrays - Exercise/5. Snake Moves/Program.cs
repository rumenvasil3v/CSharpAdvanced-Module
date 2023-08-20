using System;
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

            char[,] isleOfTheSnakeMatrix = new char[matrixRows, matrixColumns];

            SnakePatternInMatrix(isleOfTheSnakeMatrix, snakeLength);
            PrintMatrix(isleOfTheSnakeMatrix);
        }

        static void SnakePatternInMatrix(char[,] isleOfTheSnakeMatrix, string snakeLength)
        {
<<<<<<< HEAD
            
=======
            StringBuilder sb = new StringBuilder();
            sb.Append(snakeLength);
            char firstCharacter = '\0';
            char leftCharacter = '\0';
            string lastCharacters = string.Empty;
            int count = 0;

            for (int row = 0; row < isleOfTheSnakeMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < isleOfTheSnakeMatrix.GetLength(1); col++)
                {
                    isleOfTheSnakeMatrix[row, col] = sb[col];
                    if (col == isleOfTheSnakeMatrix.GetLength(1) - 1)
                    {
                        lastCharacters += isleOfTheSnakeMatrix[row, col];
                    }
                }

                count++;
                if (count == 2)
                {
                    firstCharacter = sb[0];
                    count = 0;
                    sb.Clear();
                    sb.Append(lastCharacters);

                    for (int c = isleOfTheSnakeMatrix.GetLength(1) - 2; c >= 1; c--)
                    {
                        sb.Append(isleOfTheSnakeMatrix[row, c]);
                    }

                    sb.Append(firstCharacter);

                    lastCharacters = string.Empty;
                }
                else
                {
                    for (int l = isleOfTheSnakeMatrix.GetLength(1); l < snakeLength.Length; l++)
                    {
                        leftCharacter = sb[l];
                    }

                    sb.Clear();

                    for (int c = isleOfTheSnakeMatrix.GetLength(1) - 2; c >= 0; c--)
                    {
                        sb.Append(isleOfTheSnakeMatrix[row, c]);
                    }

                    sb.Append(leftCharacter);
                    sb.Append(isleOfTheSnakeMatrix[row, isleOfTheSnakeMatrix.GetLength(1) - 1]);
                }
            }
>>>>>>> 16bb77463ae740cdd8946532eab9904b1da0a395
        }

        static void PrintMatrix(char[,] matrix)
        {
<<<<<<< HEAD
            
=======
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
>>>>>>> 16bb77463ae740cdd8946532eab9904b1da0a395
        }
    }
}