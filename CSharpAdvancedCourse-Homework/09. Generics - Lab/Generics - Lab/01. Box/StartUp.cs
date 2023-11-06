namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            Console.WriteLine(box.Count);

            box.Add("Pesho");
            box.Add("Gosho");
            box.Add("Geri");

            Console.WriteLine(box.Count);

            Console.WriteLine(box.Remove());

            Console.WriteLine(box.Count);

            box.Add("Something");
            box.Add("Arduino!");

            Console.WriteLine(box.Count);
            Console.WriteLine(box.Remove());

            Box<int> numberBox = new Box<int>();

            numberBox.Add(1);
            numberBox.Add(2);
            numberBox.Add(3);

            Console.WriteLine(numberBox.Remove());
            Console.WriteLine(numberBox.Count);
        }
    }
}