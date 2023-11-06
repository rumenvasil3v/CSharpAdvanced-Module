using System.Net;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] upperAndLowerBoundArguments = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int lowerBound = int.Parse(upperAndLowerBoundArguments[0]);
            int upperBound = int.Parse(upperAndLowerBoundArguments[1]);

            string command = Console.ReadLine();
            Predicate<int> predicate = EvenOrOdd(command);

            List<int> numbers = new List<int>();
            for (int n = lowerBound; n <= upperBound; n++)
            {
                if (predicate(Math.Abs(n)))
                {
                    numbers.Add(n);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static Predicate<int> EvenOrOdd(string command)
        {
            switch (command)
            {
                case "odd":
                    return n => n % 2 == 1;
                case "even":
                    return n => n % 2 == 0;
                default:
                    return n => false;
            }
        }
    }
}