using System.Reflection.Metadata.Ecma335;

namespace _11._Key_Revolver___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceForEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(locks);
            Stack<int> stack = new Stack<int>(bullets);

            decimal priceForAllBullets = 0;
            int bulletCount = 0;

            while (stack.Count > 0)
            {

                if (bulletCount == sizeOfGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    bulletCount = 0;
                    continue;
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine($"{stack.Count} bullets left. Earned ${valueOfIntelligence - priceForAllBullets}");
                    break;
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