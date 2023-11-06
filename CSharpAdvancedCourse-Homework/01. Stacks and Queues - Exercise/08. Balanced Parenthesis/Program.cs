namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string sequenceOfParentheses = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            // CODE LOGIC
            IterateThroughParentheses(stack, sequenceOfParentheses);
        }

        static void IterateThroughParentheses(Stack<char> stack, string sequenceOfParentheses)
        {
            // CODE LOGIC
            char closingBracket = '\0';

            bool isFalse = false;
            for (int n = 0; n < sequenceOfParentheses.Length; n++)
            {
                char currentChar = sequenceOfParentheses[n];

                switch (currentChar)
                {
                    case '(':
                        stack.Push(sequenceOfParentheses[n]);
                        break;
                    case '{':
                        stack.Push(sequenceOfParentheses[n]);
                        break;
                    case '[':
                        stack.Push(sequenceOfParentheses[n]);
                        break;
                    case ']':
                        if (CheckIfStackCountEqualsZero(stack))
                        {
                            isFalse = true;
                            break;
                        }

                        if (CheckIfBracketsAreSquare(stack))
                        {
                            continue;
                        }

                        isFalse = true;
                        break;
                    case '}':
                        if (CheckIfStackCountEqualsZero(stack))
                        {
                            isFalse = true;
                            break;
                        }

                        if (CheckIfBracketsAreCurly(stack))
                        {
                            continue;
                        }

                        isFalse = true;
                        break;
                    case ')':
                        if (CheckIfStackCountEqualsZero(stack))
                        {
                            isFalse = true;
                            break;
                        }

                        if (CheckIfBracketsAreParentheses(stack))
                        {
                            continue;
                        }

                        isFalse = true;
                        break;
                }

                if (isFalse)
                {
                    break;
                }
            }

            // OUTPUT
            CheckIfParenthesisAreBalancedAndPrint(stack, isFalse);
        }

        static void CheckIfParenthesisAreBalancedAndPrint(Stack<char> stack, bool isFalse)
        {
            // OUTPUT
            if (!isFalse && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool CheckIfStackCountEqualsZero(Stack<char> stack)
        {
            if (stack.Count == 0)
            {
                return true;
            }

            return false;
        }

        static bool CheckIfBracketsAreParentheses(Stack<char> stack)
        {
            if (stack.Pop() == '(')
            {
                return true;
            }

            return false;
        }

        static bool CheckIfBracketsAreSquare(Stack<char> stack)
        {
            if (stack.Pop() == '[')
            {
                return true;
            }

            return false;
        }

        static bool CheckIfBracketsAreCurly(Stack<char> stack)
        {
            if (stack.Pop() == '{')
            {
                return true;
            }

            return false;
        }
    }
}