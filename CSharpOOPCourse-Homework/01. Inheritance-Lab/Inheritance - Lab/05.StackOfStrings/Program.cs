namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings("Gosho");

            Console.WriteLine(stack.IsEmpty());
            stack.AddRange();
            Console.WriteLine(string.Join(" ", stack));

            Console.WriteLine(stack.IsEmpty());
        }
    }
}
