namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT /queue arguments/
            int[] queueArguments = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // INPUT /array of integers/
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = EnqueueElementsIntoQueue(queueArguments[0], arrayOfIntegers);

            DequeueElementsFromQueue(queue, queueArguments[1]);

            PrintFinalConditionOfTheQueue(queue, queueArguments[2]);
        }

        static Queue<int> EnqueueElementsIntoQueue(int elementsToEnqueue, int[] arrayOfIntegers)
        {
            Queue<int> queue = new Queue<int>();

            for (int n = 0; n < elementsToEnqueue; n++)
            {
                queue.Enqueue(arrayOfIntegers[n]);
            }

            return queue;
        }

        static void DequeueElementsFromQueue(Queue<int> queue,int elementsToDequeue)
        {
            for (int n = 0; n < elementsToDequeue; n++)
            {
                queue.Dequeue();
            }
        }

        static void PrintFinalConditionOfTheQueue(Queue<int> queue, int number)
        {
            if (queue.Contains(number))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(number) && queue.Count > 0)
            {
                int smallestNumber = queue.Min(x => x);

                Console.WriteLine(smallestNumber);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}