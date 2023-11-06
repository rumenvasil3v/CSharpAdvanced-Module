using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _10._Radioactive_Mutant_Vampire_Bunnies
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
            MovePlayer(matrix);
        }

        static void MovePlayer(char[,] matrix)
        {
            int[] playerCoordinates = AddingElementsToMatrix(matrix);

            Queue<string> queue = new Queue<string>();
            FindBunnies(queue, matrix);

            int playerRow = playerCoordinates[0];
            int playerCol = playerCoordinates[1];

            bool playerEscaped = false;
            bool playerDied = false;

            string directions = Console.ReadLine();

            foreach (char direction in directions)
            {
                switch (direction)
                {
                    case 'L':
                        if (playerCol - 1 < 0)
                        {
                            playerEscaped = true;
                            matrix[playerRow, playerCol] = '.';
                            break;
                        }

                        if (matrix[playerRow, playerCol - 1] == 'B' && playerEscaped == false)
                        {
                            playerDied = true;
                            matrix[playerRow, playerCol - 1] = 'B';
                            matrix[playerRow, playerCol] = '.';
                            playerCol--;
                            break;
                        }

                        matrix[playerRow, playerCol - 1] = 'P';
                        matrix[playerRow, playerCol] = '.';
                        playerCol--;
                        break;
                    case 'R':
                        if (playerCol + 1 >= matrix.GetLength(1))
                        {
                            playerEscaped = true;
                            matrix[playerRow, playerCol] = '.';
                            break;
                        }

                        if (matrix[playerRow, playerCol + 1] == 'B' && playerEscaped == false)
                        {
                            playerDied = true;
                            matrix[playerRow, playerCol + 1] = 'B';
                            matrix[playerRow, playerCol] = '.';
                            playerCol++;
                            break;
                        }

                        matrix[playerRow, playerCol + 1] = 'P';
                        matrix[playerRow, playerCol] = '.';
                        playerCol++;
                        break;
                    case 'U':
                        if (playerRow - 1 < 0)
                        {
                            playerEscaped = true;
                            matrix[playerRow, playerCol] = '.';
                            break;
                        }

                        if (matrix[playerRow - 1, playerCol] == 'B' && playerEscaped == false)
                        {
                            playerDied = true;
                            matrix[playerRow - 1, playerCol] = 'B';
                            matrix[playerRow, playerCol] = '.';
                            playerRow--;
                            break;
                        }

                        matrix[playerRow - 1, playerCol] = 'P';
                        matrix[playerRow, playerCol] = '.';
                        playerRow--;
                        break;
                    case 'D':
                        if (playerRow + 1 >= matrix.GetLength(0))
                        {
                            playerEscaped = true;
                            matrix[playerRow, playerCol] = '.';
                            break;
                        }

                        if (matrix[playerRow + 1, playerCol] == 'B' && playerEscaped == false)
                        {
                            playerDied = true;
                            matrix[playerRow + 1, playerCol] = 'B';
                            matrix[playerRow, playerCol] = '.';
                            playerRow++;
                            break;
                        }

                        matrix[playerRow + 1, playerCol] = 'P';
                        matrix[playerRow, playerCol] = '.';
                        playerRow++;
                        break;
                }
                
                int[] bunnyCoordinates = SpreadBunnies(queue, matrix);
                if (bunnyCoordinates[0] >= 0)
                {
                    playerDied = true;
                    playerRow = bunnyCoordinates[0];
                    playerCol = bunnyCoordinates[1];
                }

                if (playerDied)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
                    return;
                }

                if (playerEscaped)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", playerRow, playerCol);
                    return;
                }
            }
        }

        static int[] SpreadBunnies(Queue<string> queue, char[,] matrix)
        {
            int[] deadPlayerCoordinates = new int[2] { -1, -1 };

            int count = queue.Count;

            for (int q = 0; q < count; q++)
            {
                string[] bunnyArguments = queue.Dequeue().Split(',');

                int bunnyRow = int.Parse(bunnyArguments[0]);
                int bunnyCol = int.Parse(bunnyArguments[1]);

                if (bunnyCol + 1 < matrix.GetLength(1))
                {
                    if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                        deadPlayerCoordinates[0] = bunnyRow;
                        deadPlayerCoordinates[1] = bunnyCol + 1;
                    }

                    if (matrix[bunnyRow, bunnyCol + 1] == '.')
                    {
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                        queue.Enqueue($"{bunnyRow},{bunnyCol + 1}");
                    }
                }

                if (bunnyCol - 1 >= 0)
                {
                    if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                        deadPlayerCoordinates[0] = bunnyRow;
                        deadPlayerCoordinates[1] = bunnyCol - 1;
                    }

                    if (matrix[bunnyRow, bunnyCol - 1] == '.')
                    {
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                        queue.Enqueue($"{bunnyRow},{bunnyCol - 1}");
                    }
                }

                if (bunnyRow + 1 < matrix.GetLength(0))
                {
                    if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                        deadPlayerCoordinates[0] = bunnyRow + 1;
                        deadPlayerCoordinates[1] = bunnyCol;
                    }

                    if (matrix[bunnyRow + 1, bunnyCol] == '.')
                    {
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                        queue.Enqueue($"{bunnyRow + 1},{bunnyCol}");
                    }
                }

                if (bunnyRow - 1 >= 0)
                {
                    if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                    {
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                        deadPlayerCoordinates[0] = bunnyRow - 1;
                        deadPlayerCoordinates[1] = bunnyCol;
                    }

                    if (matrix[bunnyRow - 1, bunnyCol] == '.')
                    {
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                        queue.Enqueue($"{bunnyRow - 1},{bunnyCol}");
                    }
                }
            }

            return deadPlayerCoordinates;
        }

        static int[] AddingElementsToMatrix(char[,] matrix)
        {
            int[] playerCoordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string matrixElements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixElements[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerCoordinates[0] = row;
                        playerCoordinates[1] = col;
                    }
                }
            }

            return playerCoordinates;
        }

        static void FindBunnies(Queue<string> queue, char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        queue.Enqueue($"{row},{col}");
                    }
                }
            }

            var a = 0;
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