namespace _02._Generic_Box_of_Integer___exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            for (int n = 0; n < countOfNumbers; n++)
            {
                int number = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(number);

                Console.WriteLine(box.ToString());
            }
        }
    }
}