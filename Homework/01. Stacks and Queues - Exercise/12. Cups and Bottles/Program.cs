namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesWithWater = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(bottlesWithWater);
            Queue<int> queue = new Queue<int>(cupsCapacity);

            // CODE LOGIC
            PouringWaterInCups(stack, queue);
        }

        static void PouringWaterInCups(Stack<int> stack, Queue<int> queue)
        {
            // CODE LOGIC
            int wastedWater = 0;

            while (queue.Count > 0)
            {

                // POTENTIONAL OUTPUT IF THERE ARE NO MORE BOTTLES PRINT HOW MANY CUPS AREN'T FILLED
                if (CheckIfThereAreNoMoreBottles(stack, queue))
                {
                    break;
                }

                int currentCup = queue.Peek();
                int currentBottle = stack.Pop();

                if (currentCup > currentBottle)
                {
                   wastedWater = MoreThanOneBottleToFillTheCup(queue, stack, currentCup, wastedWater, currentBottle);
                }
                else if (currentBottle >= currentCup)
                {
                    wastedWater = OneBottleToFillTheCup(queue, currentCup, currentBottle, wastedWater);
                }
            }

            //OUTPUT
            PrintOutput(queue, stack);

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }

        static bool CheckIfThereAreNoMoreBottles(Stack<int> stack, Queue<int> queue)
        {
            // POTENTIONAL OUTPUT IF THERE ARE NO MORE BOTTLES PRINT HOW MANY CUPS AREN'T FILLED
            if (stack.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', queue)}");
                return true;
            }

            return false;
        }

        static int MoreThanOneBottleToFillTheCup(Queue<int> queue, Stack<int> stack, int currentCup, int wastedWater, int currentBottle)
        {
            // CODE LOGIC
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
                queue.Dequeue();
            }

            return wastedWater;
        }

        static int OneBottleToFillTheCup(Queue<int> queue, int currentCup, int currentBottle, int wastedWater)
        {
            // CODE LOGIC
            while (currentCup > 0)
            {
                currentCup--;
                currentBottle--;
            }

            wastedWater += currentBottle;
            queue.Dequeue();

            return wastedWater;
        }

        static void PrintOutput(Queue<int> queue, Stack<int> stack)
        {
            // OUTPUT
            if (queue.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stack)}");
            }
        }
    }
}