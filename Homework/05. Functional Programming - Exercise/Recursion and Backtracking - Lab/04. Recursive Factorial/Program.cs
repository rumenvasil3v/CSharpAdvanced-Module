using System;

namespace _04._Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FactorialOfNumber(number));
        }

        public static int FactorialOfNumber(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number *= FactorialOfNumber(number - 1);
        }
    }
}