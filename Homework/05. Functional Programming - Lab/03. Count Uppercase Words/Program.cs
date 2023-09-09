namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = x => { return char.IsUpper(x[0]); };
            var lineOfText = Console.ReadLine().Split(' ').Where(func);
            Console.WriteLine(string.Join(Environment.NewLine, lineOfText));
        }
    }
}