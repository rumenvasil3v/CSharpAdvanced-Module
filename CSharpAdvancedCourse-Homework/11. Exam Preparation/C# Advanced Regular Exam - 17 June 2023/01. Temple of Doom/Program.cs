namespace _01._Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTools = Console.ReadLine();
            int[] tools = inputTools.Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(tools);
            
            string inputSubstances = Console.ReadLine();
            int[] substances = inputSubstances.Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(substances);

            string inputChallenges = Console.ReadLine();
            List<int> challenges = inputChallenges.Split(' ').Select(int.Parse).ToList();

            while (challenges.Count > 0)
            {
                if (queue.Count == 0 || stack.Count == 0)
                {
                    break;
                }

                int currentTool = queue.Peek();
                int currentSubstance = stack.Peek();

                if (challenges.Any(x => x == currentTool * currentSubstance))
                {
                    int value = challenges.FirstOrDefault(x => x == currentTool * currentSubstance);

                    queue.Dequeue();
                    stack.Pop();
                    challenges.Remove(value);
                }
                else
                {
                    currentTool++;
                    queue.Dequeue();
                    queue.Enqueue(currentTool);

                    currentSubstance--;
                    stack.Pop();
                    stack.Push(currentSubstance);
                    if (stack.Peek() == 0)
                    {
                        stack.Pop();
                    }
                }
            }

            if (challenges.Count > 0)
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }
            else
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Tools: {string.Join(", ", queue)}");
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"Substances: {string.Join(", ", stack)}");
            }

            if (challenges.Count > 0)
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}