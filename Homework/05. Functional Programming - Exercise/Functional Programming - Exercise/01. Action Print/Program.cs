using System.Net;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomText = Console.ReadLine().Split(' ');
            //Action<string> action = ModelOfOutput;
            Action<string> action = x => Console.WriteLine(x);

            foreach (string word in randomText)
            {
                action(word);
            }
        }

        //static void ModelOfOutput(string word) => Console.WriteLine(word);
    }
}