namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialFuel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(initialFuel);

            int[] consumptionIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(consumptionIndexes);

            int[] quantities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queueQuantities = new Queue<int>(quantities); 

            List<string> reachedAltitudes = new List<string>();

            int countOfAltitudes = 1;
            while (queueQuantities.Count > 0)
            {
                int fuel = stack.Peek();
                int consumptionIndex = queue.Peek();

                int quantity = queueQuantities.Peek();

                if (fuel - consumptionIndex >= quantity)
                {
                    reachedAltitudes.Add($"Altitude {countOfAltitudes}");
                    Console.WriteLine($"John has reached: Altitude {countOfAltitudes++}");

                    stack.Pop();
                    queue.Dequeue();
                    queueQuantities.Dequeue();
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {countOfAltitudes}");
                    break;
                }
            }

            if (queueQuantities.Count > 0 && reachedAltitudes.Count > 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", reachedAltitudes)}");
            }
            else if (queueQuantities.Count > 0 && reachedAltitudes.Count == 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}