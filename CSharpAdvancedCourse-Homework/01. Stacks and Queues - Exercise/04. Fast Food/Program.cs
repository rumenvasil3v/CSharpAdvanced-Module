namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT /Quantity of foof/
            int quantityOfFood = int.Parse(Console.ReadLine());

            // INPUT /array of integers/
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(arrayOfIntegers);

            // CODE LOGIC
            Console.WriteLine(queue.Max());

            DequeueOrders(queue, quantityOfFood, arrayOfIntegers); // dequeue orders from the queue
            PrintInformationAboutOrders(queue); // print if it has orders or if it does not have
        }

        static void DequeueOrders(Queue<int> queue, int quantityOfFood, int[] arrayOfIntegers)
        {
            for (int n = 0; n < arrayOfIntegers.Length; n++)
            {
                // check if we have enough food to execute the order
                if (quantityOfFood - arrayOfIntegers[n] >= 0)
                {
                    quantityOfFood -= arrayOfIntegers[n];
                    queue.Dequeue();
                }
                else
                {

                    break; // if we don't have food, break and print remaining orders
                }
            }
        }

        static void PrintInformationAboutOrders(Queue<int> queue)
        {
            // OUTPUT

            if (queue.Count == 0) // check if queue count equals zero
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}"); // if count is > 0, print remaining orders
            }
        }
    }
}