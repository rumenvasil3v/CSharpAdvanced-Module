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
            ManipulateTraffic(queue, durationOfGreenLight, freeWindow);
        }

        static void ManipulateTraffic(Queue<string> queue, int durationOfGreenLight, int freeWindow)
        {
            int totalCars = 0;

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "green":

                        int secondsGreenLight = durationOfGreenLight;
                        int secondsFreeWindow = freeWindow;
                        int count = queue.Count;

                        for (int n = 0; n < count; n++)
                        {
                            bool carPassedSuccessfully = false;

                            if (secondsGreenLight == 0)
                            {
                                break;
                            }

                            string currentCar = queue.Dequeue();

                            Queue<char> carQueue = new Queue<char>(currentCar);

                            while (secondsGreenLight > 0)
                            {
                                secondsGreenLight--;
                                carQueue.Dequeue();
                                if (carQueue.Count == 0)
                                {
                                    totalCars++;
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
                                        totalCars++;
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
                                    return;
                                }
                            }
                        }
                        break;
                    default:
                        string car = command;

                        EnqueueCarToTraffic(queue, car);
                        break;
                }
            }

            if (command == "END")
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }

        static void EnqueueCarToTraffic(Queue<string> queue, string car)
        {
            queue.Enqueue(car);
        }
    }
}