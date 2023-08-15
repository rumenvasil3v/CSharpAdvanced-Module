namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequenceOfParenthesis = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            IterateThroughParenthesis(stack, sequenceOfParenthesis);
        }

        static void IterateThroughParenthesis(Stack<char> stack, string sequenceOfParenthesis)
        {
            char closingBracket = '\0';

            bool isFalse = false;
            for (int n = 0; n < sequenceOfParenthesis.Length; n++)
            {
                char currentChar = sequenceOfParenthesis[n];

                switch (currentChar)
                {
                    case '(':
                        stack.Push(sequenceOfParenthesis[n]);
                        break;
                    case '{':
                        stack.Push(sequenceOfParenthesis[n]);
                        break;
                    case '[':
                        stack.Push(sequenceOfParenthesis[n]);
                        break;
                    case ']':
                        if (stack.Count == 0)
                        {
                            isFalse = true;
                            break;
                        }
                        
                        if (stack.Pop() == '[')
                        {
                            continue;
                        }

                        isFalse = true;
                        break;
                    case '}':
                        if (stack.Count == 0)
                        {
                            isFalse = true;
                            break;
                        }
                        
                        if (stack.Pop() == '{')
                        {
                            continue;
                        }

                        isFalse = true;
                        break;
                    case ')':
                        if (stack.Count == 0)
                        {
                            isFalse = true;
                            break;
                        }
                        
                        if (stack.Pop() == '(')
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

            CheckIfParenthesisAreBalanced(stack, isFalse);
        }

        static void CheckIfParenthesisAreBalanced(Stack<char> stack, bool isFalse)
        {
            if (!isFalse && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}