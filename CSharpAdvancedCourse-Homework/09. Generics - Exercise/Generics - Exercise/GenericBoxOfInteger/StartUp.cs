namespace GenericExercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<int> boxOfIntegers = new Box<int>();
            for (int n = 0; n < numberOfLines; n++)
            {
                int number = int.Parse(Console.ReadLine());

                boxOfIntegers.Add(number);
            }

            Console.WriteLine(boxOfIntegers.ToString());
        }
    }
}