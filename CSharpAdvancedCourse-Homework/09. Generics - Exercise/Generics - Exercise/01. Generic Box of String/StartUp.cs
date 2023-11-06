namespace GenericExercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int n = 0; n < numberOfLines; n++)
            {
                string currentText = Console.ReadLine();

                box.Add(currentText);
            }

            Console.WriteLine(box.ToString());
        }
    }
}