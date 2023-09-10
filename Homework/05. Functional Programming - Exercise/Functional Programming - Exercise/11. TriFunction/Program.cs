//using System.Linq;

//namespace _11._TriFunction
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int bound = int.Parse(Console.ReadLine());

//            var names = Console.ReadLine().Split(' ');

//            foreach (string name in names)
//            {
//                bool isValid = MainFunction(name, x => x >= bound);
//                if (isValid)
//                {
//                    Console.WriteLine(name);
//                    break;
//                }
//            }
//        }

//        static bool MainFunction(string name, Func<int, bool> func)
//        {
//            int sum = 0;

//            foreach (char character in name)
//            {
//                sum += character;
//            }

//            return func(sum);
//        }
//    }
//}

using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bound = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(' ');

            Func<string, bool> func = x =>
            {
                int sum = 0;

                foreach (var character in x)
                {
                    sum += character;
                }

                return sum >= bound;
            };

            var firstName = names.FirstOrDefault(func);
            Console.WriteLine(firstName);
        }
    }
}