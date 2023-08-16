/*
5
1 5
10 3
10 4
8 8
6 9 -> Output 1

4
1 1
1 5
1 1
5 1

7
1 10
10 1
6 6
1 10
6 6
6 15
10 5 -> Output 2
 */

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int numberOfPetrolPumps = Math.Abs(int.Parse(Console.ReadLine()));

            // CODE LOGIC
            PetrolPumps(numberOfPetrolPumps);
        }

        static void PetrolPumps(int numberOfPetrolPumps)
        {
            // CODE LOGIC
            int leftAmount = 0;
            Stack<int> stack = new Stack<int>();

            for (int n = 0; n < numberOfPetrolPumps; n++)
            {
                int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                int amountOfPetrol = arrayOfIntegers[0];
                amountOfPetrol += leftAmount;
                int distanceInKiolometers = arrayOfIntegers[1];

                amountOfPetrol = DistanceTravelled(distanceInKiolometers, amountOfPetrol);

                if (amountOfPetrol >= 0)
                {
                    leftAmount = amountOfPetrol;
                    stack.Push(n);
                }
                else
                {
                    leftAmount = 0;
                    stack.Clear();
                }
            }

            // OUTPUT
            PrintSmallestIndexStartRoute(stack);
        }

        static int DistanceTravelled(int distance, int amountOfPetrol)
        {
            for (int d = 0; d < distance; d++)
            {
                amountOfPetrol--;
            }

            return amountOfPetrol;
        }

        static void PrintSmallestIndexStartRoute(Stack<int> stack)
        {
            // OUTPUT
            while (stack.Count > 0)
            {

                if (stack.Count == 1)
                {
                    Console.WriteLine(stack.Pop());
                    break;
                }

                stack.Pop();
            }
        }
    }
}