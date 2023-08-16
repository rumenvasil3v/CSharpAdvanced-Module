/*
8 7 4 9 10 5 6
19
 */

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT /arrayOfIntegers/
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // INPUT /capacityOfRack/
            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(arrayOfIntegers);

            // CODE LOGIC
            GettingClothesFromTheBox(stack, arrayOfIntegers, capacityOfRack); // invkoke method
        }

        static void GettingClothesFromTheBox(Stack<int> stack,int[] arrayOfIntegers, int capacityOfRack)
        {
            int racks = 1; 
            int sum = 0;

            while (stack.Count > 0)
            {
                int currentElement = stack.Pop();
              
                sum += currentElement;
                if (sum == capacityOfRack && stack.Count > 0) // check if our capacity equals to the rack capacity and if there are more clothes for another rack
                {
                    sum = 0; 
                    racks++; // get new rack
                }
                else if (sum > capacityOfRack) // check if we filled up the rack more than it's capacity
                {      
                    stack.Push(currentElement); // if we filled it up more we don't put tje clothe on it
                    sum = 0;
                    racks++; // get new rack
                }
            }

            // OUTPUT
            Console.WriteLine(racks);
        }
    }
}