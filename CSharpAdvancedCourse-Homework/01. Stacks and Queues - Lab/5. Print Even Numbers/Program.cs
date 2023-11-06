namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int[] arrayOfIntegers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = DequeueOddNumbers(arrayOfIntegers);

            PrintAllEvenNumbers(queue);
        }

        static Queue<int> DequeueOddNumbers(int[] arrayOfIntegers)
        {
            // INITIALIZING QUEUE
            Queue<int> queue = new Queue<int>(arrayOfIntegers);

            // CODE LOGIC
            for (int n = 0; n < arrayOfIntegers.Length; n++)
            {

                // DEQUEUE IF NUMBER IS ODD
                if (arrayOfIntegers[n] % 2 == 1)
                {
                    queue.Dequeue();
                }
                else
                {
                    // DEQUEUE AND ENQUEUE IF NUMBER IF EVEN BECAUSE WE WANT TO REMOVE ONLY ODD NUMBERS
                    queue.Dequeue();
                    queue.Enqueue(arrayOfIntegers[n]);
                }
            }

            return queue;
        }

        static void PrintAllEvenNumbers(Queue<int> queue)
        {
            // OUTPUT
            while (queue.Count > 0)
            {

                if (queue.Count == 1)
                {
                    // BREAK BECAUSE WHEN WE DEQUEUE OUR COUNT IS ZERO
                    Console.WriteLine(queue.Dequeue());
                    break;
                }

                Console.Write($"{queue.Dequeue()}, ");
            }
        }
    }
}