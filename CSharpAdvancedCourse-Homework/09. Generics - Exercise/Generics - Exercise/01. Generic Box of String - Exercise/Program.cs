namespace _01._Generic_Box_of_String___Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfStrings; n++)
            {
                string text = Console.ReadLine();

                Box<string> box = new Box<string>(text);

                Console.WriteLine(box.ToString());
            }
        }
    }
}