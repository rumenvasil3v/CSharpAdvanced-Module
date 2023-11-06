namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var names = Console
                .ReadLine()
                .Split(' ');

            Predicate<string> predicate = n => n.Length <= number;
            var filteredNames = names.Where(n => predicate(n));

            Console.WriteLine(string.Join(Environment.NewLine, filteredNames));
        }
    }
}