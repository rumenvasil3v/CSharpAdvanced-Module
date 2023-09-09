namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> func = x => x % 2 == 0;
            Func<int, int> orderFunc = x => x;

            string input = Console.ReadLine();
            string[] inputSplitted = input.Split(", ");
            var numbers = inputSplitted.Select(int.Parse).Where(func).OrderBy(orderFunc);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}