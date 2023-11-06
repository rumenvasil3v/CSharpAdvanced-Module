namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT 
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            // CODE LOGIC
            for (int n = 0; n < numberOfQueries; n++)
            {
                int[] currentQuery = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Queries(stack, currentQuery);
            }

            PrintConditionOfTheStack(stack);
        }

        static void Queries(Stack<int> stack, int[] currentQuery)
        {

            switch(currentQuery[0])
            {
                case 1:
                    int elementToPush = currentQuery[1];

                    stack.Push(elementToPush);
                    break;
                case 2:
                    stack.Pop();
                    break;
                case 3:
                    if (stack.Count == 0)
                    {
                        return;
                    }
                    int maximumElement = stack.Max();

                    Console.WriteLine(maximumElement);
                    break;
                case 4:
                    if (stack.Count == 0)
                    {
                        return;
                    }
                    int minimumElement = stack.Min();

                    Console.WriteLine(minimumElement);
                    break;
            }
        }

        static void PrintConditionOfTheStack(Stack<int> stack)
        {
            // OUTPUT /First Option/
            Console.WriteLine(string.Join(", ", stack));

            // OUTPUT /Second Option/
            while (stack.Count > 0)
            {

                if (stack.Count == 1)
                {
                    Console.WriteLine(stack.Pop());
                    break;
                }

                Console.Write($"{stack.Pop()}, ");
            }
        }
    }
}