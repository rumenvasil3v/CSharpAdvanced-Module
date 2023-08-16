namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesWithWater = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(cupsCapacity);
            Stack<int> stack = new Stack<int>(bottlesWithWater);

            int wastedWater = 0;
            int leftWater = 0;

            while (queue.Count > 0)
            {

                if (stack.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(' ', queue)}");
                    break;
                }

                int currentCup = queue.Peek();
                int currentBottle = stack.Pop();

                if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        currentCup--;
                        currentBottle--;
                        if (currentBottle == 0 && currentCup > 0)
                        {
                            if (stack.Count == 0)
                            {
                                break;
                            }
                            currentBottle = stack.Pop();
                        }
                    }

                    wastedWater += currentBottle;

                    if (currentCup <= 0)
                    {
                        leftWater = currentBottle;
                        queue.Dequeue();
                    }
                }
                else if (currentBottle >= currentCup)
                {
                    while (currentCup > 0)
                    {
                        currentCup--;
                        currentBottle--;
                    }

                    wastedWater += currentBottle;
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stack)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}