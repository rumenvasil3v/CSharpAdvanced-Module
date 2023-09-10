/*
Monica Ivelina MJ Rumen Peter
Double StartsWith MJ
Double EndsWith lina
Party!

 */

using System;
using System.Diagnostics.Contracts;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console
                .ReadLine()
                .Split(' ')
                .ToList();

            string command = Console.ReadLine();
            while (true)
            {
                if (command == "Party!")
                {
                    break;
                }

                string[] commandArguments = command.Split(' ');

                Predicate<string> criteriaPredicate = Criteria(commandArguments[1], commandArguments[2]);

                switch (commandArguments[0])
                {
                    case "Remove":
                        people.RemoveAll(criteriaPredicate);
                        break;
                    case "Double":
                        var matches = people.FindAll(criteriaPredicate);
                        if (matches.Count > 0)
                        {
                            var index = people.FindIndex(criteriaPredicate);
                            people.InsertRange(index, matches);
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> Criteria(string criteria, string criteriaArgument)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return p => p.StartsWith(criteriaArgument);
                case "EndsWith":
                    return p => p.EndsWith(criteriaArgument);
                case "Length":
                    return p => p.Length == int.Parse(criteriaArgument);
                default:
                    throw new ArgumentException("Invalid criteria -> {0}", criteria);
            }
        }
    }
}