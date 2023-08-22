﻿/*
2
KK
KK

5 
0K0K0
K000K
00K00
K000K 
0K0K0

8
0K0KKK00
0K00KKKK
00K0000K
KKKKKK0K
K0K0000K
KK00000K
00K0K000
000K00KK
 */

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

            //if (sizeOfBoard < 3)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}

            int column = 0;
            int countOfattackedKnights = 0;
            for (int row = 0; row < chessMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < chessMatrix.GetLength(1); col++)
                {
                    if (chessMatrix[row, col] == 'K')
                    {

                        if (col - 2 >= 0)
                        {
                            if (row + 1 < chessMatrix.GetLength(0))
                            {
                                char firstCharacter = chessMatrix[row + 1, col - 2];
                                if (firstCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row + 1, col - 2] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }

                            if (row - 1>= 0)
                            {
                                char secondCharacter = chessMatrix[row - 1, col - 2];
                                if (secondCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row - 1, col - 2] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }
                        }
                        if (col + 2 < chessMatrix.GetLength(1))
                        {
                            if (row + 1 < chessMatrix.GetLength(0))
                            {
                                char firstCharacter = chessMatrix[row + 1, col + 2];
                                if (firstCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row + 1, col + 2] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }

                            if (row - 1 >= 0)
                            {
                                char secondCharacter = chessMatrix[row - 1, col + 2];
                                if (secondCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row - 1, col + 2] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }
                        }
                        if (row - 2 >= 0)
                        {
                            if (col + 1 < chessMatrix.GetLength(1))
                            {
                                char firstCharacter = chessMatrix[row - 2, col + 1];
                                if (firstCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row - 2, col + 1] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }

                            if (col - 1 >= 0)
                            {
                                char secondCharacter = chessMatrix[row - 2, col - 1];
                                if (secondCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row - 2, col - 1] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }
                        }
                        if (row + 2 < chessMatrix.GetLength(0))
                        {
                            if (col + 1 < chessMatrix.GetLength(1))
                            {
                                char firstCharacter = chessMatrix[row + 2, col + 1];
                                if (firstCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row + 2, col + 1] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }

                            if (col - 1 >= 0)
                            {
                                char secondCharacter = chessMatrix[row + 2, col - 1];
                                if (secondCharacter == 'K')
                                {
                                    chessMatrix[row, col] = '0';
                                    chessMatrix[row + 2, col - 1] = 'K';
                                    countOfattackedKnights++;
                                    continue;
                                }
                            }
                        }
                        //if (col - 1 >= 0)
                        //{
                        //    if (row + 2 < chessMatrix.GetLength(0))
                        //    {
                        //        char firstCharacter = chessMatrix[row + 2, col - 1];
                        //        if (firstCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row + 2, col - 1] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }

                        //    if (row - 2 >= 0)
                        //    {
                        //        char secondCharacter = chessMatrix[row - 2, col - 1];
                        //        if (secondCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row - 2, col - 1] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }
                        //}
                        //if (col + 1 < chessMatrix.GetLength(1))
                        //{
                        //    if (row + 2 < chessMatrix.GetLength(0))
                        //    {
                        //        char firstCharacter = chessMatrix[row + 2, col + 1];
                        //        if (firstCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row + 2, col + 1] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }

                        //    if (row - 2 >= 0)
                        //    {
                        //        char secondCharacter = chessMatrix[row - 2, col + 1];
                        //        if (secondCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row - 2, col + 1] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }
                        //}
                        //if (row - 1 >= 0)
                        //{
                        //    if (col - 2 >= 0)
                        //    {
                        //        char firstCharacter = chessMatrix[row - 1, col - 2];
                        //        if (firstCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row - 1, col - 2] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }

                        //    if (col + 2 < chessMatrix.GetLength(1))
                        //    {
                        //        char secondCharacter = chessMatrix[row - 1, col + 2];
                        //        if (secondCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row - 1, col + 2] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }
                        //}
                        //if (row + 1 < chessMatrix.GetLength(0))
                        //{
                        //    if (col - 2 >= 0)
                        //    {
                        //        char firstCharacter = chessMatrix[row + 1, col - 2];
                        //        if (firstCharacter == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row + 1, col - 2] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }

                        //    if (col + 2 < chessMatrix.GetLength(1))
                        //    {
                        //        char secondChar = chessMatrix[row + 1, col + 2];
                        //        if (secondChar == 'K')
                        //        {
                        //            chessMatrix[row, col] = '0';
                        //            chessMatrix[row + 1, col + 2] = 'K';
                        //            countOfattackedKnights++;
                        //            continue;
                        //        }
                        //    }
                        //}
                    }
                }
            }

            Console.WriteLine(countOfattackedKnights);
        }
    }
}