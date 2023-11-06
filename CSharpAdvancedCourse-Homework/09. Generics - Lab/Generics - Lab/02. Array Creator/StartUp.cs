namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Hello");
            Console.WriteLine(string.Join(", ", strings));
            char[] chars = ArrayCreator.Create(10, '^');
            Console.WriteLine(string.Join(", ", chars));
        }
    }
}