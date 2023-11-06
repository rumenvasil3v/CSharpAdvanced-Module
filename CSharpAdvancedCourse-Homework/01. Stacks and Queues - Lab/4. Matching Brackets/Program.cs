using System.Linq.Expressions;
using System.Text;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string expression = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            IterateThroughString(stack, expression);
        }

        static void IterateThroughString(Stack<int> stack, string expression)
        {
            // CODE LOGIC
            for (int n = 0; n < expression.Length; n++)
            {
                if (CheckWhetherCharacterIsOpeningBracket(expression[n]))
                {
                    stack.Push(n);
                }
                else if (CheckWhetherCharacterIsClosingBracket(expression[n]))
                {
                    PrintExpressionBetweenBrackets(stack, expression, n);
                }
            }
        }

        static bool CheckWhetherCharacterIsOpeningBracket(char expressionCharacter)
        {
            if (expressionCharacter == '(')
            {
                return true;
            }

            return false;
        }

        static bool CheckWhetherCharacterIsClosingBracket(char expressionCharacter)
        {
            if (expressionCharacter == ')')
            {
                return true;
            }

            return false;
        }

        static void PrintExpressionBetweenBrackets(Stack<int> stack, string expression, int n)
        {
            // INITIALIZING STRINGBUILDER
            StringBuilder sb = new StringBuilder();

            // POP INDEX OF OPENING BRACKET
            int openBracketIndex = stack.Pop();

            // SET CURRENT INDEX AS CLOSING BRACKET
            int closingBracketIndex = n;

            // APPEND SUBSTRING FROM OPENING TO CLOSING BRACKET IN StringBuilder
            sb.Append(expression.Substring(openBracketIndex, closingBracketIndex - openBracketIndex + 1));

            // PRINT CURRENT SUB-EXPRESSION
            Console.WriteLine(sb.ToString());
        }
    }
}