namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> integerScale = new EqualityScale<int>(13, 113);

            Console.WriteLine(integerScale.AreEqual());
        }
    }
}