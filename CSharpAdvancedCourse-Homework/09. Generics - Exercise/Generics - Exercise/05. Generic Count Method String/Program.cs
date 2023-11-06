using _03._Generic_Swap_Method_String___Exercise;

namespace _05._Generic_Count_Method_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int n = 0; n < numberOfElements; n++)
            {
                string element = Console.ReadLine();

                list.Add(element);
            }

            string valueOfElementForComparison = Console.ReadLine();

            Console.WriteLine(Box<string>.CountStrings(list, valueOfElementForComparison));
        }
    }
}