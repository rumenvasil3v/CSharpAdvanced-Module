using System;

namespace _02._Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            DrawFigure(number);
        }

        public static void DrawFigure(int number)
        {
            if (number == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', number));
            DrawFigure(number - 1);
            //Console.WriteLine(new string('#', number));
        }
    }
}