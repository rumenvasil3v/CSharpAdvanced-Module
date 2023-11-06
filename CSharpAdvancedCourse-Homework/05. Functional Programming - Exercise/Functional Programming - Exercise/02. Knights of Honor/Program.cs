namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            Action<string> action = name => Console.WriteLine($"Sir {name}");

            foreach (var name in names)
            {
                action(name);
            }
        }
    }
}