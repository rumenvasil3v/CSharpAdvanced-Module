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

            // CODE LOGIC
            for (int n = 0; n < expression.Length; n++)
            {
                if (expression[n] == '(')
                {
                    stack.Push(n);
                }
                else if (expression[n] == ')')
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
    }
}