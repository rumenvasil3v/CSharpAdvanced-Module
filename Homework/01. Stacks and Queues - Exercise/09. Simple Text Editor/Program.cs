/*
9
1 HelloThere
3 7
2 2
3 5
4
3 7
4
1 TestPassed
3 5
 */

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            // CODE LOGIC
            ManipulateString(stack, numberOfOperations);
        }

        static void ManipulateString(Stack<string> stack, int numberOfOperations)
        {
            // CODE LOGIC
            for (int n = 0; n < numberOfOperations; n++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        string text = command[1];

                        PushingCharactersIntoStack(text, stack);
                        break;
                    case "2":
                        int countCharactersToRemove = int.Parse(command[1]);

                        string modifiedString = string.Empty;

                        if (stack.Count == 0)
                        {
                            break;
                        }

                        string currentText = stack.Peek();

                        for (int t = 0; t < currentText.Length - countCharactersToRemove; t++)
                        {
                            modifiedString += currentText[t];
                        }

                        stack.Push(modifiedString);
                        break;
                    case "3":
                        int indexToPrint = int.Parse(command[1]);

                        if (stack.Count == 0)
                        {
                            break;
                        }

                        // OUTPUT
                        Console.WriteLine(stack.Peek()[indexToPrint - 1]);
                        break;
                    case "4":
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        stack.Pop();

                        break;
                }
            }
        }

        static void PushingCharactersIntoStack(string text, Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                string currentText = stack.Pop();
                stack.Push(currentText);
                currentText += text;
                stack.Push(currentText);
                return;
            }
            stack.Push(text);
        }
    }
}