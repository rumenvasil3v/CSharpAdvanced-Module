namespace _07_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queueTruck = new Queue<int>();

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                var information = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int amountOfPetrol = information[0];
                int distance = information[1];

                queueTruck.Enqueue(amountOfPetrol - distance);
            }

            for (int i = 0; i < n; i++)
            {
                if (queueTruck.Peek() >= 0)
                {
                    foreach (var elm in queueTruck)
                    {
                        sum += elm;
                        if (sum < 0)
                        {
                            break;
                        }
                    }

                    if (sum >= 0)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    else
                    {
                        queueTruck.Enqueue(queueTruck.Peek());
                        queueTruck.Dequeue();
                        sum = 0;
                    }
                }
                else
                {
                    queueTruck.Enqueue(queueTruck.Peek());
                    queueTruck.Dequeue();
                }
            }
        }
    }
}