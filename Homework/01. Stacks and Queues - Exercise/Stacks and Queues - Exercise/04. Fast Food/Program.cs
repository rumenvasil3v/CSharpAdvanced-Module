namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(arrayOfIntegers);

            Console.WriteLine(queue.Max());

            DequeueOrders(queue, quantityOfFood, arrayOfIntegers);
            PrintInformationAboutOrders(queue);
        }

        static void DequeueOrders(Queue<int> queue, int quantityOfFood, int[] arrayOfIntegers)
        {
            for (int n = 0; n < arrayOfIntegers.Length; n++)
            {
                if (quantityOfFood - arrayOfIntegers[n] >= 0)
                {
                    quantityOfFood -= arrayOfIntegers[n];
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
        }

        static void PrintInformationAboutOrders(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}