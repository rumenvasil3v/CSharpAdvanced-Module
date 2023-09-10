using System.Diagnostics.SymbolStore;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Predicate<string> predicate = x => x[0] == x.ToUpper()[0];
            //string[] lineOfText = Console
            //    .ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Where(w => predicate(w))
            //    .ToArray();

            //Console.WriteLine(string.Join(Environment.NewLine, lineOfText));

            Func<string, bool> func = x => char.IsUpper(x[0]);
            string[] lineOfText = Console
                 .ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Where(func)
                 .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, lineOfText));
        }
    }
}