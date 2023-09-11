using System;
using System.Numerics;

namespace _04._Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            number = FactorialOfNumber(number);
            Console.WriteLine(number);
        }

        public static BigInteger FactorialOfNumber(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * FactorialOfNumber(number - 1);
        }
    }
}