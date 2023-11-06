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
                string currentElement = Console.ReadLine();

                box.Add(currentElement);
            }

            SwapElements(box);

            Console.WriteLine(box.ToString());
        }

        static void SwapElements<T>(Box<T> list)
        {
            string[] indexes = Console
                .ReadLine()
                .Split(' ');

            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);

            T firstElement = list.Items[firstIndex];
            list.Items[firstIndex] = list.Items[secondIndex];
            list.Items[secondIndex] = firstElement;
        }
    }
}