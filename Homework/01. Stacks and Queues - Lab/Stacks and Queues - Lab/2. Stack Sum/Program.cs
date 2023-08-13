namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // PUSHING ELEMENTS IN STACK FROM THE LIST
            Stack<int> stack = new Stack<int>(numbers);

            // CODE LOGIC
            string command;
            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                // SPLITTING COMMAND INTO ARGUMENTS
                string[] arguments = command.Split();

                switch (arguments[0].ToString())
                {
                    case "ADD":
                        int firstNumber = int.Parse(arguments[1]);
                        int secondNumber = int.Parse(arguments[2]);

                        // PUSHING ELEMENTS IN STACK
                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                        break;
                    case "REMOVE":
                        int countOfNumbersToRemove = int.Parse(arguments[1]);

                        // POP Nth COUNT ELEMENTS
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

            // OUTPUT
            PrintSumOfTheElementsInTheStack(stack);
        }

        static void PrintSumOfTheElementsInTheStack(Stack<int> stack)
        {
            // PRINT SUM OF THE REMAINING ELEMENTS
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine(sum);
        }
    }
}