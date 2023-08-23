
using System;
using System.Collections.Generic;


namespace CurrentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Tuple<int, int>> kniteMoves = new Queue<Tuple<int, int>>();
            kniteMoves.Enqueue(new Tuple<int, int>(-1, -2));
            kniteMoves.Enqueue(new Tuple<int, int>(+1, -2));
            kniteMoves.Enqueue(new Tuple<int, int>(-2, -1));
            kniteMoves.Enqueue(new Tuple<int, int>(+2, -1));
            kniteMoves.Enqueue(new Tuple<int, int>(-2, +1));
            kniteMoves.Enqueue(new Tuple<int, int>(+2, +1));
            kniteMoves.Enqueue(new Tuple<int, int>(-1, +2));
            kniteMoves.Enqueue(new Tuple<int, int>(+1, +2));

            int boardSize = int.Parse(Console.ReadLine());

            string[,] board = new string[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                char[] curRow = Console.ReadLine().ToCharArray();
                for (int k = 0; k < boardSize; k++)
                {
                    board[i, k] = curRow[k].ToString();
                }

            }

            bool foundHit = true;
            int mostHits = 0;
            int saveMostHits = 0;
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;
            int removedResult = 0;
            while (foundHit == true)
            {

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int k = 0; k < board.GetLength(1); k++)
                    {
                        if (board[i, k] == "K")
                        {
                            for (int j = 1; j <= kniteMoves.Count; j++)
                            {
                                int row = kniteMoves.Peek().Item1;
                                int col = kniteMoves.Peek().Item2;

                                kniteMoves.Enqueue(kniteMoves.Dequeue());
                                try
                                {
                                    if (board[i + row, k + col] == "K")
                                    {
                                        mostHits++;
                                    }

                                }
                                catch (Exception)
                                {

                                    continue;
                                }
                            }

                        }
                        if (mostHits > 0)
                        {
                            foundHit = true;
                        }
                        else
                        {
                            foundHit = false;
                        }
                        if (mostHits > saveMostHits)
                        {
                            bestRow = i;
                            bestCol = k;
                            saveMostHits = mostHits;
                        }
                        mostHits = 0;
                    }
                }

                if (foundHit = true && bestRow != int.MinValue && bestCol != int.MinValue)
                {
                    board[bestRow, bestCol] = "0";
                    removedResult++;
                }
                saveMostHits = 0;
                bestRow = int.MinValue;
                bestCol = int.MinValue;
            }
            Console.WriteLine(removedResult);
        }
    }
}
/*
8
000KKK00
0K00KKKK
00K0000K
KKKKKK0K
K0K0000K
KK00000K
00K0K000
000K000K
*/

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfBoard = int.Parse(Console.ReadLine());

            char[,] chessMatrix = new char[sizeOfBoard, sizeOfBoard];

            AddingElementsToMatrix(chessMatrix);

            int countOfattackedKnights = 0;
            for (int row = 0; row < chessMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < chessMatrix.GetLength(1); col++)
                {

                }
            }

            Console.WriteLine(countOfattackedKnights);
        }

        static void AddingElementsToMatrix(char[,] chessMatrix)
        {
            for (int row = 0; row < chessMatrix.GetLength(0); row++)
            {
                string chessMatrixElements = Console.ReadLine();

                for (int col = 0; col < chessMatrix.GetLength(1); col++)
                {
                    chessMatrix[row, col] = chessMatrixElements[col];
                }
            }
        }
    }
}

