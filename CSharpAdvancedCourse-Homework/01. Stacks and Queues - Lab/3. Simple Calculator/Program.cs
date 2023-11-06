namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string[] expression = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(expression);

            // INITIALIZING POSITIVE AND NEGATIVE NUMBERS
            int positiveNumbers = 0;
            int negativeNumbers = 0;

            // INITIALIZING SIGN
            char sign = '\0';

            // CODE LOGIC
            while (stack.Count > 0)
            {
                // POP NUMBER AND SET IT TO VARIABLE
                int number = int.Parse(stack.Pop());

                if (stack.Count > 0)
                {
                    // WHILE OUR COUNT IS MORE THAN ZERO WE POP AND GET OUR SIGN
                    sign = char.Parse(stack.Pop());
                }
                else
                {
                    // IF COUNT IS ZERO THAT MEANS WE ARE AT THE LAST NUMBER AND THAT MEANS THE SIGN IS POSITIVE
                    sign = '+';
                }
    
                if (sign == '+')
                {
                    // ADD NUMBER TO positiveNumbers
                    positiveNumbers += number;
                }
                else if (sign == '-')
                {
                    // ADD NUMEBR TO negativeNumbers
                    negativeNumbers -= number;
                }
            }

            // OUTPUT
            Console.WriteLine(positiveNumbers + negativeNumbers);
        }
    }
}