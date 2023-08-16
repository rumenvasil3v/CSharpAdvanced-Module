using System.Net;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            ManipulateTraffic(stack, queue, durationOfGreenLight, freeWindow);
        }

        static void ManipulateTraffic(Stack<string> stack, Queue<string> queue, int durationOfGreenLight, int freeWindow)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "green":
                        bool isThereAccident = CarPassingThroughCrossroad(stack, queue, durationOfGreenLight, freeWindow);

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

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{stack.Count} total cars passed the crossroads.");
        }

        static void EnqueueCarToTraffic(Queue<string> queue, string car)
        {
            queue.Enqueue(car);
        }

        static bool CarPassingThroughCrossroad(Stack<string> stack, Queue<string> queue, int durationOfGreenLight, int freeWindow)
        {
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