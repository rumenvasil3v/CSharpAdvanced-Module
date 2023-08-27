using System.Data;
using System.Reflection.PortableExecutable;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfBoard = int.Parse(Console.ReadLine());

            char[,] chessMatrix = new char[sizeOfBoard, sizeOfBoard];

            for (int row = 0; row < chessMatrix.GetLength(0); row++)
            {
                string chessMatrixElements = Console.ReadLine();

                for (int col = 0; col < chessMatrix.GetLength(1); col++)
                {
                    chessMatrix[row, col] = chessMatrixElements[col];
                }
            }

            int removeKnightsCount = 0;
            while (true)
            {
                int maxAttackedKnights = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < chessMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < chessMatrix.GetLength(1); col++)
                    {
                        int currentAttackedKnights = 0;

                        if (chessMatrix[row, col] != 'K')
                        {
                            continue;
                        }
                        else
                        {
                            if (IsInside(chessMatrix, row - 2, col + 1) && chessMatrix[row - 2, col + 1] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row - 1, col + 2) && chessMatrix[row - 1, col + 2] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row + 1, col + 2) && chessMatrix[row + 1, col + 2] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row + 2, col + 1) && chessMatrix[row + 2, col + 1] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row + 2, col - 1) && chessMatrix[row + 2, col - 1] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row + 1, col - 2) && chessMatrix[row + 1, col - 2] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row - 1, col - 2) && chessMatrix[row - 1, col - 2] == 'K')
                            {
                                currentAttackedKnights++;
                            }

                            if (IsInside(chessMatrix, row - 2, col - 1) && chessMatrix[row - 2, col - 1] == 'K')
                            {
                                currentAttackedKnights++;
                            }
                        }

   
                        if (currentAttackedKnights > maxAttackedKnights)
                        {
                            maxAttackedKnights = currentAttackedKnights;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }
                else
                {
                    chessMatrix[knightRow, knightCol] = '0';
                    removeKnightsCount++;
                }
            }

            Console.WriteLine(removeKnightsCount);
        }

        static bool IsInside(char[,] chessMatrix, int row, int col)
        {
            return row >= 0 && row < chessMatrix.GetLength(0)
                && col >= 0 && col < chessMatrix.GetLength(1);
        }
    }
}