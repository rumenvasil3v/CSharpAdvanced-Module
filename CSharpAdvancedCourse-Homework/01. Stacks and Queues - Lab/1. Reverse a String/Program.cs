namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string input = Console.ReadLine();

            //Declaring Stack of type char
            Stack<char> stack = new Stack<char>();
            
            foreach (char character in input)
            {
                //Pushing characters to our stack
                stack.Push(character);
            }

            //FIRST OUTPUT OPTION

            //foreach (char ch in input)
            //{
            //    Console.Write(stack.Pop());
            //}

            //SECOND OUTPUT OPTION

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}

            //THIRD OUTPUT OPTION

            //Console.WriteLine(string.Join("", stack));
        }
    }
}