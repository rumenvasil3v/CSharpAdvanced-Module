using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();

            string input = Console.ReadLine();
            string[] matrixArguments = input.Split(' ');

            int matrixRows = int.Parse(matrixArguments[0]);
            int matrixCols = int.Parse(matrixArguments[1]);
<<<<<<< HEAD

            char[,] matrix = new char[matrixRows, matrixCols];

            string text = Console.ReadLine();
            int count = 0;

            for (int t = 0; t < matrixRows * matrixCols; t++)
            {
                queue.Enqueue(text[count++]);

                if (count == text.Length)
                {
                    count = 0;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                }

                if (row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
=======

            char[,] matrix = new char[matrixRows, matrixCols];
>>>>>>> d619e64948b808d6a4ff1648b98d8b20789d1cfa
        }
    }
}