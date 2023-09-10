namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            var numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse);

            List<int> validNumbers = new List<int>(); 
            for (int n = 1; n <= endOfRange; n++)
            {
                Predicate<int> predicate = x => n % x == 0;

                bool isDivisible = numbers.All(x => predicate(x));
                if (isDivisible)
                {
                    validNumbers.Add(n);
                }
            }

            Console.WriteLine(string.Join(' ', validNumbers));
        }
    }
}