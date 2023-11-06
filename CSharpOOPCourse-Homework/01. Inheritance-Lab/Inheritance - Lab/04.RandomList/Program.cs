namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList strings = new RandomList();

            strings.Add("Pesho");
            strings.Add("Pepi");
            strings.Add("Gosho");
             
            string result = strings.RandomString();
            Console.WriteLine(result);
        }
    }
}
