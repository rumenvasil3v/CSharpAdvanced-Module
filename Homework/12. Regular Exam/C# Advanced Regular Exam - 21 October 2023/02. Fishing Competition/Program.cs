/*
4
---S
----
9-5-
34--
up
left
left
down
collect the nets

5
S---9
777-1
W333-
11111
-----
down
down
right
down
collect the nets

 */

namespace _02._Fishing_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquare = int.Parse(Console.ReadLine());

            char[,] squareMatrix = new char[sizeOfSquare, sizeOfSquare];

            int rowVesselPosition = 0;
            int colVesselPosition = 0;
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = elements[col];

                    if (squareMatrix[row, col] == 'S')
                    {
                        rowVesselPosition = row;
                        colVesselPosition = col;
                    }
                }
            }

            int tonsOfFishForSuccessfulSeason = 20;
            int totalTons = 0;

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                switch (command)
                {
                    case "up":
                        if (rowVesselPosition - 1 < 0)
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';

                            rowVesselPosition = squareMatrix.GetLength(0) - 1;

                            if (squareMatrix[rowVesselPosition, colVesselPosition] == 'W')
                            {
                                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                                return;
                            }

                            if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition]))
                            {
                                char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                                string currentTon = ton.ToString();

                                totalTons += int.Parse(currentTon);
                            }

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (char.IsDigit(squareMatrix[rowVesselPosition - 1, colVesselPosition]))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            rowVesselPosition--;
                            char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                            string currentTon = ton.ToString();

                            totalTons += int.Parse(currentTon);

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (squareMatrix[rowVesselPosition - 1, colVesselPosition] == 'W')
                        {
                            rowVesselPosition--;
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                            return;
                        }

                        if (squareMatrix[rowVesselPosition - 1, colVesselPosition] == '-')
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            rowVesselPosition--;
                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                        }
                        break;
                    case "down":
                        if (rowVesselPosition + 1 >= squareMatrix.GetLength(0))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';

                            rowVesselPosition = 0;

                            if (squareMatrix[rowVesselPosition, colVesselPosition] == 'W')
                            {
                                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                                return;
                            }

                            if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition]))
                            {
                                char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                                string currentTon = ton.ToString();

                                totalTons += int.Parse(currentTon);
                            }

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (char.IsDigit(squareMatrix[rowVesselPosition + 1, colVesselPosition]))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            rowVesselPosition++;
                            char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                            string currentTon = ton.ToString();

                            totalTons += int.Parse(currentTon);

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (squareMatrix[rowVesselPosition + 1, colVesselPosition] == 'W')
                        {
                            rowVesselPosition++;
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                            return;
                        }

                        if (squareMatrix[rowVesselPosition + 1, colVesselPosition] == '-')
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            rowVesselPosition++;
                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                        }
                        break;
                    case "left":
                        if (colVesselPosition - 1 < 0)
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';

                            colVesselPosition = squareMatrix.GetLength(1) - 1;

                            if (squareMatrix[rowVesselPosition, colVesselPosition] == 'W')
                            {
                                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                                return;
                            }

                            if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition]))
                            {
                                char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                                string currentTon = ton.ToString();

                                totalTons += int.Parse(currentTon);
                            }

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition - 1]))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            colVesselPosition--;
                            char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                            string currentTon = ton.ToString();

                            totalTons += int.Parse(currentTon);

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (squareMatrix[rowVesselPosition, colVesselPosition - 1] == 'W')
                        {
                            colVesselPosition--;
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                            return;
                        }

                        if (squareMatrix[rowVesselPosition, colVesselPosition - 1] == '-')
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            colVesselPosition--;
                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                        }
                        break;
                    case "right":
                        if (colVesselPosition + 1 >= squareMatrix.GetLength(1))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';

                            colVesselPosition = 0;

                            if (squareMatrix[rowVesselPosition, colVesselPosition] == 'W')
                            {
                                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                                return;
                            }

                            if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition]))
                            {
                                char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                                string currentTon = ton.ToString();

                                totalTons += int.Parse(currentTon);
                            }

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (char.IsDigit(squareMatrix[rowVesselPosition, colVesselPosition + 1]))
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            colVesselPosition++;
                            char ton = squareMatrix[rowVesselPosition, colVesselPosition];
                            string currentTon = ton.ToString();

                            totalTons += int.Parse(currentTon);

                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                            break;
                        }

                        if (squareMatrix[rowVesselPosition, colVesselPosition + 1] == 'W')
                        {
                            colVesselPosition++;
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowVesselPosition},{colVesselPosition}]");
                            return;
                        }

                        if (squareMatrix[rowVesselPosition, colVesselPosition + 1] == '-')
                        {
                            squareMatrix[rowVesselPosition, colVesselPosition] = '-';
                            colVesselPosition++;
                            squareMatrix[rowVesselPosition, colVesselPosition] = 'S';
                        }
                        break;
                }
            }

            if (totalTons >= tonsOfFishForSuccessfulSeason)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {tonsOfFishForSuccessfulSeason - totalTons} tons of fish more.");
            }

            if (totalTons > 0)
            {
                Console.WriteLine($"Amount of fish caught: {totalTons} tons.");
            }

            PrintMatrix(squareMatrix);
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
    }
}