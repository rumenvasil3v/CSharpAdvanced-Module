/*
5
up right right up right
* * * c *
* * * e *
* * c * *
s * * c *
* * c * *

 */

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
            
            

            string[] directions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int countOfCoals = 0;
            int minerRow = 0;
            int minerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                string[] matrixElements = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(matrixElements[col]);

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

            foreach (string direction in directions)
            {
                switch (direction)
                {
                    case "left":
                        if (minerCol - 1 < 0)
                        {
                            break;
                        }

                        if (matrix[minerRow, minerCol - 1] == 'c')
                        {
                            countOfCoals--;
                        }

                        if (matrix[minerRow, minerCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol - 1})");
                            return;
                        }
                        matrix[minerRow, minerCol - 1] = 's';
                        matrix[minerRow, minerCol] = '*';
                        minerCol--;

                        if (countOfCoals == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                    case "right":
                        if (minerCol + 1 >= matrix.GetLength(1))
                        {
                            break;
                        }

                        if (matrix[minerRow, minerCol + 1] == 'c')
                        {
                            countOfCoals--;
                        }

                        if (matrix[minerRow, minerCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol + 1})");
                            return;
                        }
                        matrix[minerRow, minerCol + 1] = 's';
                        matrix[minerRow, minerCol] = '*';
                        minerCol++;

                        if (countOfCoals == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                    case "up":
                        if (minerRow - 1 < 0)
                        {
                            break;
                        }

                        if (matrix[minerRow - 1, minerCol] == 'c')
                        {
                            countOfCoals--;
                        }

                        if (matrix[minerRow - 1, minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow - 1}, {minerCol})");
                            return;
                        }
                        matrix[minerRow - 1, minerCol] = 's';
                        matrix[minerRow, minerCol] = '*';
                        minerRow--;

                        if (countOfCoals == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                    case "down":
                        if (minerRow + 1 >= matrix.GetLength(0))
                        {
                            break;
                        }

                        if (matrix[minerRow + 1, minerCol] == 'c')
                        {
                            countOfCoals--;
                        }

                        if (matrix[minerRow + 1, minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow + 1}, {minerCol})");
                            return;
                        }
                        matrix[minerRow + 1, minerCol] = 's';
                        matrix[minerRow, minerCol] = '*';
                        minerRow++;

                        if (countOfCoals == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                }
            }

            if (countOfCoals > 0)
            {
                Console.WriteLine($"{countOfCoals} coals left. ({minerRow}, {minerCol})");
            }
        }

        static void AddingElementsToMatrix(char[,] matrix)
        {
            
        }

        static void PrintMatrix(char[,] matrix, int count, int minerRow, int minerCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Coals: {count}; Miner Row: {minerRow}; Miner Col: {minerCol}");
        }
    }
}