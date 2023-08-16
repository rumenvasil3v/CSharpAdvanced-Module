using System.Reflection.Metadata.Ecma335;

namespace _11._Key_Revolver___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int priceForEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);

            // CODE LOGIC
            DestroyingLocks(stack, queue, priceForEachBullet, sizeOfGunBarrel, valueOfIntelligence);
        }

        static void DestroyingLocks(Stack<int> stack, Queue<int> queue, int priceForEachBullet, int sizeOfGunBarrel, int valueOfIntelligence)
        {
            // CODE LOGIC
            decimal priceForAllBullets = 0;
            int bulletCount = 0;

            while (stack.Count > 0)
            {

                bulletCount = CheckIfSamNeedsToReload(bulletCount, sizeOfGunBarrel);

                // POTENTIONAL OUTPUT IF THERE ARE STILL BULLETS BUT LOCKS ARE DESTROYED
                if (CheckIfSamDestroyedAllLocks(stack, queue, valueOfIntelligence, priceForAllBullets))
                {
                    return;
                }

                int bulletSize = stack.Pop();

                priceForAllBullets += priceForEachBullet;

                int lockSize = queue.Peek();

                if (bulletSize <= lockSize)
                {
                    queue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bulletCount++;
            }

            // OUTPUT
            PrintOutput(queue, stack, valueOfIntelligence, priceForAllBullets);
        }

        static int CheckIfSamNeedsToReload(int bulletCount, int sizeOfGunBarrel)
        {
            if (bulletCount == sizeOfGunBarrel)
            {
                Console.WriteLine("Reloading!");
                bulletCount = 0;
            }

            return bulletCount;
        }

        static bool CheckIfSamDestroyedAllLocks(Stack<int> stack, Queue<int> queue, int valueOfIntelligence, decimal priceForAllBullets)
        {
            // POTENTIONAL OUTPUT IF THERE ARE STILL BULLETS BUT LOCKS ARE DESTROYED
            if (queue.Count == 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${valueOfIntelligence - priceForAllBullets}");
                return true;
            }

            return false;
        }

        static void PrintOutput(Queue<int> queue, Stack<int> stack, int valueOfIntelligence, decimal priceForAllBullets)
        {
            // OUTPUT
            if (stack.Count == 0 && queue.Count == 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${valueOfIntelligence - priceForAllBullets}");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}