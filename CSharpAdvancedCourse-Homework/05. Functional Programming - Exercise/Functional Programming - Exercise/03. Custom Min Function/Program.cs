namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Func<int, int> func = x => x;
            Console.WriteLine(numbers.Min(func));

            //int minNumber = Min2(numbers, x => x);
            //Console.WriteLine(minNumber);
        }

        //static int Min2(List<int> numbers, Func<int, double> func)
        //{
        //    int minNumber = int.MaxValue;

        //    for (int n = 0; n < numbers.Count; n++)
        //    {
        //        double currentNumber = func(numbers[n]);

        //        if (currentNumber < minNumber)
        //        {
        //            minNumber = numbers[n];
        //        }
        //    }

        //    return minNumber;
        //}
    }
}