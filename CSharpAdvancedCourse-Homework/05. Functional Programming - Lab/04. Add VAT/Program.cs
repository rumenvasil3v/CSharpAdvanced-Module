namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> func = x => x + x * 0.2;
            var prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(func).Select(x => $"{x:F2}");
            Console.WriteLine(string.Join(Environment.NewLine, prices));
        }
    }
}