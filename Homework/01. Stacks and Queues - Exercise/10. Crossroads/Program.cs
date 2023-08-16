using System.Net;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            // CODE LOGIC
            ManipulateTraffic(stack, queue, durationOfGreenLight, freeWindow);
        }

        static void ManipulateTraffic(Stack<string> stack, Queue<string> queue, int durationOfGreenLight, int freeWindow)
        {
            // CODE LOGIC
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "green":
                        bool isThereAccident = CarPassingThroughCrossroad(stack, queue, durationOfGreenLight, freeWindow);

                        // POTENTIAL OUTPUT IF CAR CRASHES
                        if (isThereAccident)
                        {
                            return;
                        }

                        break;
                    default:
                        string car = command;

                        EnqueueCarToTraffic(queue, car);
                        break;
                }
            }

            // OUTPUT
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{stack.Count} total cars passed the crossroads.");
        }

        static void EnqueueCarToTraffic(Queue<string> queue, string car)
        {
            // ENQUEUE CAR
            queue.Enqueue(car);
        }

        static bool CarPassingThroughCrossroad(Stack<string> stack, Queue<string> queue, int durationOfGreenLight, int freeWindow)
        {
            // CAR PASSING WHEN IS GREEN LIGHT
            bool accident = false;

            int secondsGreenLight = durationOfGreenLight;
            int secondsFreeWindow = freeWindow;
            int count = queue.Count;

            for (int n = 0; n < count; n++)
            {

                if (secondsGreenLight == 0)
                {
                    break;
                }

                bool carPassedSuccessfully = false;

                string currentCar = queue.Dequeue();

                Queue<char> carQueue = new Queue<char>(currentCar);

                while (secondsGreenLight > 0)
                {
                    secondsGreenLight--;
                    carQueue.Dequeue();
                    if (carQueue.Count == 0)
                    {
                        stack.Push(currentCar);
                        carPassedSuccessfully = true;
                        break;
                    }
                }

                if (carPassedSuccessfully)
                {
                    continue;
                }
                else
                {
                    while (secondsFreeWindow > 0)
                    {
                        carQueue.Dequeue();
                        secondsFreeWindow--;
                        if (carQueue.Count == 0)
                        {
                            stack.Push(currentCar);
                            carPassedSuccessfully = true;
                            break;
                        }
                    }

                    if (carPassedSuccessfully)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {carQueue.Dequeue()}.");
                        accident = true;
                        break;
                    }
                }
            }

            return accident;
        }
    }
}