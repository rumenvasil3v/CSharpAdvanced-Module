/*
5,5
**M**
*@@**
CC@**
**@@*
**CC*
left
down
left
down
down
down
right
danger
 */

namespace _02._Mouse_In_The_Kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixDimensions = input.Split(",");

            int rows = int.Parse(matrixDimensions[0]);
            int cols = int.Parse(matrixDimensions[1]);

            char[,] matrix = new char[rows, cols];

            int totalCountOfCheese = 0;
            int mouseRow = 0;
            int mouseCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];

                    if (matrix[row, col] == 'M')
                    {
                        mouseRow = row;
                        mouseCol = col;
                    }

                    if (matrix[row, col] == 'C')
                    {
                        totalCountOfCheese++;
                    }
                }
            }

            int mouseCollectedCheese = 0;

            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                switch (command)
                {
                    case "up":
                        if (IsMouseOutOfTheCupboardArea(mouseRow, mouseCol, command, matrix))
                        {
                            Console.WriteLine("No more cheese for tonight!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[mouseRow, mouseCol] = '*';

                            if (matrix[mouseRow - 1, mouseCol] == 'T')
                            {
                                mouseRow--;
                                matrix[mouseRow, mouseCol] = 'M';
                                Console.WriteLine("Mouse is trapped!");
                                PrintMatrix(matrix);
                                return;
                            }

                            if (matrix[mouseRow - 1, mouseCol] == '@')
                            {
                                matrix[mouseRow, mouseCol] = 'M';
                            }
                            else
                            {
                                if (matrix[mouseRow - 1, mouseCol] == 'C')
                                {
                                    mouseCollectedCheese++;
                                }

                                mouseRow--;
                                matrix[mouseRow, mouseCol] = 'M';

                                if (mouseCollectedCheese == totalCountOfCheese)
                                {
                                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                                    PrintMatrix(matrix);
                                    return;
                                }
                            }
                        }
                        break;
                    case "down":
                        if (IsMouseOutOfTheCupboardArea(mouseRow, mouseCol, command, matrix))
                        {
                            Console.WriteLine("No more cheese for tonight!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[mouseRow, mouseCol] = '*';

                            if (matrix[mouseRow + 1, mouseCol] == 'T')
                            {
                                mouseRow++;
                                matrix[mouseRow, mouseCol] = 'M';
                                Console.WriteLine("Mouse is trapped!");
                                PrintMatrix(matrix);
                                return;
                            }

                            if (matrix[mouseRow + 1, mouseCol] == '@')
                            {
                                matrix[mouseRow, mouseCol] = 'M';   
                            }
                            else
                            {
                                if (matrix[mouseRow + 1, mouseCol] == 'C')
                                {
                                    mouseCollectedCheese++;
                                }

                                mouseRow++;
                                matrix[mouseRow, mouseCol] = 'M';

                                if (mouseCollectedCheese == totalCountOfCheese)
                                {
                                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                                    PrintMatrix(matrix);
                                    return;
                                }
                            }
                        }
                        break;
                    case "right":
                        if (IsMouseOutOfTheCupboardArea(mouseRow, mouseCol, command, matrix))
                        {
                            Console.WriteLine("No more cheese for tonight!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[mouseRow, mouseCol] = '*';

                            if (matrix[mouseRow, mouseCol + 1] == 'T')
                            {
                                mouseCol++;
                                matrix[mouseRow, mouseCol] = 'M';
                                Console.WriteLine("Mouse is trapped!");
                                PrintMatrix(matrix);
                                return;
                            }

                            if (matrix[mouseRow, mouseCol + 1] == '@')
                            {
                                matrix[mouseRow, mouseCol] = 'M';
                            }
                            else
                            {
                                if (matrix[mouseRow, mouseCol + 1] == 'C')
                                {
                                    mouseCollectedCheese++;
                                }

                                mouseCol++;
                                matrix[mouseRow, mouseCol] = 'M';

                                if (mouseCollectedCheese == totalCountOfCheese)
                                {
                                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                                    PrintMatrix(matrix);
                                    return;
                                }
                            }
                        }
                        break;
                    case "left":
                        if (IsMouseOutOfTheCupboardArea(mouseRow, mouseCol, command, matrix))
                        {
                            Console.WriteLine("No more cheese for tonight!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[mouseRow, mouseCol] = '*';

                            if (matrix[mouseRow, mouseCol - 1] == 'T')
                            {
                                mouseCol--;
                                matrix[mouseRow, mouseCol] = 'M';
                                Console.WriteLine("Mouse is trapped!");
                                PrintMatrix(matrix);
                                return;
                            }

                            if (matrix[mouseRow, mouseCol - 1] == '@')
                            {
                                matrix[mouseRow, mouseCol] = 'M';
                            }
                            else
                            {
                                if (matrix[mouseRow, mouseCol - 1] == 'C')
                                {
                                    mouseCollectedCheese++;
                                }

                                mouseCol--;
                                matrix[mouseRow, mouseCol] = 'M';

                                if (mouseCollectedCheese == totalCountOfCheese)
                                {
                                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                                    PrintMatrix(matrix);
                                    return;
                                }
                            }
                        }
                        break;
                }
            }

            Console.WriteLine("Mouse will come back later!");
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        static bool IsMouseOutOfTheCupboardArea(int currentRow, int currentCol, string direction, char[,] matrix)
        {
            bool isOutsideOfTheArea = false;

            switch (direction)
            {
                case "up":
                    if (currentRow - 1 < 0)
                    {
                        isOutsideOfTheArea = true;
                    }
                    break;
                case "down":
                    if (currentRow + 1 >= matrix.GetLength(0))
                    {
                        isOutsideOfTheArea = true;
                    }
                    break;
                case "right":
                    if (currentCol + 1 >= matrix.GetLength(1))
                    {
                        isOutsideOfTheArea = true;
                    }
                    break;
                case "left":
                    if (currentCol - 1 < 0)
                    {
                        isOutsideOfTheArea = true;
                    }
                    break;
            }

            return isOutsideOfTheArea;
        }
    }
}