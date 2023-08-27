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

            char[,] matrix = new char[matrixRows, matrixCols];
        }
    }
}