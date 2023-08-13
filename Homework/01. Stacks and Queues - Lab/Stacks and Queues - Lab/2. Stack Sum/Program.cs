namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>();

            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            string command;
            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] arguments = command.Split();

                switch (arguments[0].ToString())
                {
                    case "ADD":
                        int firstNumber = int.Parse(arguments[1]);
                        int secondNumber = int.Parse(arguments[2]);

                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                        break;
                    case "REMOVE":
                        int countOfNumbersToRemove = int.Parse(arguments[1]);

                        if (countOfNumbersToRemove <= stack.Count)
                        {
                            while (countOfNumbersToRemove > 0)
                            {
                                stack.Pop();
                                countOfNumbersToRemove--;
                            }
                        }
                        break;
                }
            }

            PrintSumOfTheElementsInTheStack(stack);
        }

        static void PrintSumOfTheElementsInTheStack(Stack<int> stack)
        {
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}