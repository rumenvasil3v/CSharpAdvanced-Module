namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string[] kids = Console.ReadLine().Split();

            // INVOKING METHOD
            Queue<string> queue = RemoveEveryNthKidFromTheGame(kids);

            // OUTPUT /PRINT LAST CHILD/ 
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        static Queue<string> RemoveEveryNthKidFromTheGame(string[] kids)
        {
            Queue<string> queue = new Queue<string>(kids);

            // COUNT WHERE Nth CHILD WILL BE OUT OF THE GAME
            int count = int.Parse(Console.ReadLine());

            // CODE LOGIC
            while (queue.Count > 1)
            {
                for (int n = 0; n < count; n++)
                {
                    if (n == count - 1)
                    {
                        // DEQUEUE CHILD WHEN N EQUALS COUNT
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    }
                    else
                    {
                        // SET CURRENT CHILD TO VARIABLE
                        string currentPlayer = queue.Dequeue();

                        // ENQUEUE CURRENT CHILD IN QUEUE
                        queue.Enqueue(currentPlayer);
                    }
                }
            }

            // RETURN LAST CHILD
            return queue;
        }
    }
}