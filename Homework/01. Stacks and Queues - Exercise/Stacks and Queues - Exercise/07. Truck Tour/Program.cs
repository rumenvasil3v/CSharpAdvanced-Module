namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());

            PetrolPumps(numberOfPetrolPumps);
        }

        static void PetrolPumps(int numberOfPetrolPumps)
        {
            int smallest = int.MaxValue;
            Stack<int> stack = new Stack<int>();

            for (int n = 0; n < numberOfPetrolPumps; n++)
            {
                int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int amountOfPetrol = arrayOfIntegers[0];
                int distanceInKiolometers = arrayOfIntegers[1];
                stack.Push(n);

                for (int d = 0; d < distanceInKiolometers; d++)
                {
                    amountOfPetrol--;
                }

                if (amountOfPetrol > 0)
                {
                    if (smallest > n)
                    {
                        smallest = n;
                    }
                }
            }

            Console.WriteLine(smallest);
        }
    }
}