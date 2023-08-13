namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPassDuringGreenLight = int.Parse(Console.ReadLine());

            int numberOfCarsPassedTheCrossroad = CarTrafficManipulating(numberOfCarsThatCanPassDuringGreenLight);

            Console.WriteLine($"{numberOfCarsPassedTheCrossroad} cars passed the crossroads.");
        }

        static int CarTrafficManipulating(int numberOfCarsPerGreenLight)
        {
            int totalPassedCars = 0;

            Queue<string> queue = new Queue<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "green":
                       totalPassedCars = CountOfCarsPassing(queue, numberOfCarsPerGreenLight, totalPassedCars);
                        break;
                    default:
                        queue.Enqueue(command);
                        break;
                }
            }

            return totalPassedCars;
        }

        static int CountOfCarsPassing(Queue<string> queue, int numberOfCarsPerGreenLight, int totalPassedCars)
        {
            for (int n = 0; n < numberOfCarsPerGreenLight; n++)
            {

                if (queue.Count == 0)
                {
                    break;
                }

                totalPassedCars++;
                Console.WriteLine($"{queue.Dequeue()} passed!");
            }

            return totalPassedCars;
        }
    }
}