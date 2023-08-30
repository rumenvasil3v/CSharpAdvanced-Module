using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int numberOfNames = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfNames; n++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
