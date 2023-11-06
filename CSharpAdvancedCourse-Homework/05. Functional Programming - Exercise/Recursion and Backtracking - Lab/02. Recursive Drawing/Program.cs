using System;

namespace _02._Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            DrawFigure(1, number);
        }

        public static void DrawFigure(int number, int bound)
        {
            if (number == bound + 1)
            {
                Console.WriteLine(new string('*', number));
                return;
            }

            Console.WriteLine(new string('*', number));
            DrawFigure(number + 1, bound);
            Console.WriteLine(new string('*', number));
        }
    }
}