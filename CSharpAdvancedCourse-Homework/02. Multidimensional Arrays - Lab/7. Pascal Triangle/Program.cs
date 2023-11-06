using System.Numerics;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            BigInteger[][] jaggedArray = new BigInteger[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = new BigInteger[row + 1];
                jaggedArray[row][0] = 1;
                jaggedArray[row][jaggedArray[row].Length - 1] = 1;

                AddElementsToEveryColumn(jaggedArray, row);

                //Console.Write(new string(new string(' ', rows - row)));

                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }

        static void AddElementsToEveryColumn(BigInteger[][] jaggedArray, int row)
        {
            for (int col = 0; col < jaggedArray[row].Length - 2; col++)
            {
                jaggedArray[row][col + 1] = jaggedArray[row - 1][col] + jaggedArray[row - 1][col + 1];
            }
        }
    }
}