namespace _04._Generic_Swap_Method_Integer___Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<int>> boxes = new List<Box<int>>();

            for (int n = 0; n < numberOfLines; n++)
            {
                int number = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(number);

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