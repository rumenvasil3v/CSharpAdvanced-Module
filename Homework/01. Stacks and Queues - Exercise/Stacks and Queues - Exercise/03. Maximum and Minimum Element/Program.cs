namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int n = 0; n < numberOfQueries; n++)
            {
                int[] currentQuery = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Queries(stack, currentQuery);
            }

            Console.WriteLine(string.Join(", ", stack));
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
                    int maximumElement = stack.Max();

                    Console.WriteLine(maximumElement);
                    break;
                case 4:
                    int minimumElement = stack.Min();

                    Console.WriteLine(minimumElement);
                    break;
            }


            /*
9
1 47
1 66
1 32
4
3
1 25
1 16
1 8
4
             */
        }
    }
}