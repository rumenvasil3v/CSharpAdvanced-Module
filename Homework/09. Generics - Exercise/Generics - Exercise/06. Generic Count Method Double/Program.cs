namespace _06._Generic_Count_Method_Double
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int n = 0; n < numberOfElements; n++)
            {
                double element = double.Parse(Console.ReadLine());

                list.Add(element);
            }

            double valueOfElementForComparison = double.Parse(Console.ReadLine());

            Console.WriteLine(Box<double>.CountStrings(list, valueOfElementForComparison));
        }
    }
}