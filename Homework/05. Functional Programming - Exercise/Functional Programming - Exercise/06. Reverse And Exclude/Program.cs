namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse);

            int divisor = int.Parse(Console.ReadLine());
            Predicate<int> predicate = n => !(n % divisor == 0);

            numbers = numbers.Reverse();
            var filteredNumbers = numbers.Where(n => predicate(n));

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}