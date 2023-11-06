using System;

namespace _05._Paths_in_Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 3 };
            int[] secondArray = { 2, 4 };
            int[] newArray = firstArray.Concat(secondArray).ToArray();

            Array.Sort(newArray);


            double median = (newArray[newArray.Length / 2 - 1] + newArray[newArray.Length / 2]) / 2.0;
            Console.WriteLine(median);

        }
    }
}