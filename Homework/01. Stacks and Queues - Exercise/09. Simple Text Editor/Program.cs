namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> firstStack = new Stack<string>();
            Stack<string> secondStack = new Stack<string>();

            ManipulateString(firstStack, secondStack, numberOfOperations);
        }

        static void ManipulateString(Stack<string> firstStack, Stack<string> secondStack, int numberOfOperations)
        {
            for (int n = 0; n < numberOfOperations; n++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        string text = command[1];

                        secondStack.Push(string.Empty);

                        PushingCharactersIntoStack(text, firstStack);
                        break;
                    case "2":
                        int countCharactersToRemove = int.Parse(command[1]);

                        string result = string.Empty;

                        

                        secondStack.Push(result);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }
        }

        static void PushingCharactersIntoStack(string text, Stack<string> firstStack)
        {
            firstStack.Push(text);
        }
    }
}