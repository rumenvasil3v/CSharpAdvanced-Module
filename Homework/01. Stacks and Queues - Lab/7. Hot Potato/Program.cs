namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> children = Console.ReadLine().Split().ToList();
            Queue<string> queue = new Queue<string>(children);

            Queue<string> removedChildren = new Queue<string>();

            int passes = int.Parse(Console.ReadLine());

            int nextChild = 0;

            while (removedChildren.Count + 1 != queue.Count)
            {
                for (int n = nextChild; n < passes; n++)
                {
                    if (n == passes - 1)
                    {
                        removedChildren.Enqueue(children[n % children.Count]);
                        Console.WriteLine($"Removed {children[n % children.Count]}");
                        children.RemoveAt(n % children.Count);

                        nextChild = n % children.Count;
                    }
                }
            }

            string lastPlayer = string.Empty;

            foreach (var child in queue)
            {
                if (!removedChildren.Contains(child))
                {
                    lastPlayer = child;
                    break;
                }
            }

            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}