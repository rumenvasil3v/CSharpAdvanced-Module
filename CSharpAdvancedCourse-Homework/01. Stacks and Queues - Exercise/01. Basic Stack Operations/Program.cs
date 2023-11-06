using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT /stack arguments/
            int[] stackArguments = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // INPUT /array of integers/
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            // Pushing elements in stack
            PushElementsIntoStack(stack, arrayOfIntegers, stackArguments[0]);

            // Pop elements in stack
            PopElementsFromStack(stack, stackArguments[1]);

            if (CheckIfCountOfStackIsZero(stack)) // Check if stack count is zero
            {
                Console.WriteLine(0);
            }
            else if (CheckIfStackContainsNumber(stack, stackArguments[2])) // Check if stack contains number
            {
                Console.WriteLine("true");
            }
            else
            {
                PrintSmallestElementInStack(stack); // Print smallest number in stack
            }
        }

        static void PushElementsIntoStack(Stack<int> stack, int[] arrayOfIntegers, int elementsToPush)
        {
            for (int n = 0; n < elementsToPush; n++)
            {
                stack.Push(arrayOfIntegers[n]);
            }
        }

        static void PopElementsFromStack(Stack<int> stack, int elementsToPop)
        {
            for (int n = 0; n < elementsToPop; n++)
            {
                stack.Pop();
            }
        }

        static bool CheckIfCountOfStackIsZero(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return true;
            }

            return false;
        }

        static bool CheckIfStackContainsNumber(Stack<int> stack, int number)
        {
            if (stack.Contains(number))
            {
                return true;
            }

            return false;
        }

        static void PrintSmallestElementInStack(Stack<int> stack)
        {
            int smallestNumber = stack.Min(x => x);

            Console.WriteLine(smallestNumber);
        }
    }
}