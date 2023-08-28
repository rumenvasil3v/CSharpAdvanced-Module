using System;
using System.Collections.Generic;

namespace _11._Matrix_of_Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] matrixArguments = input.Split();

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixCols = int.Parse(matrixArguments[1]);

            string[,] matrix = new string[matrixRows, matrixCols];

            AddingElementsToMatrix(matrix);
            PrintMatrix(matrix);
        }

        static void AddingElementsToMatrix(string[,] matrix)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Queue<char> queueRows = new Queue<char>(alphabet);
      
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Queue<char> queueCols = new Queue<char>(alphabet);
                for (int q = 0; q < row; q++)
                {
                    queueCols.Dequeue();
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string text = queueRows.Peek().ToString() + queueCols.Dequeue().ToString() + queueRows.Peek().ToString();

                    matrix[row, col] = text;
                }

                queueRows.Dequeue();
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
