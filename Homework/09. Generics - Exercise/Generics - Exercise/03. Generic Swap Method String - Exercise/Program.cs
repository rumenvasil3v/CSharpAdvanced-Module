using System.Transactions;

namespace _03._Generic_Swap_Method_String___Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int n = 0; n < numberOfLines; n++)
            {
                string text = Console.ReadLine();

                Box<string> box = new Box<string>(text);

                boxes.Add(box);
            }

            int[] swapCommand = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            SwapElements(boxes, firstIndex, secondIndex);

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }

        static void SwapElements<T>(List<Box<T>> list, int firstIndex, int secondIndex)
        {
            Box<T> firstElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstElement;
        }
    }
}