/*
Light | Pesho
Pesho -> Dark
Pesho -> Light
Blue | Pesho
Red | Pesho
Lumpawaroo
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> forceSides = new Dictionary<string, HashSet<string>>();

            //HashSet<string> lighterSide = new HashSet<string>();
            //HashSet<string> darkerSide = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] commandArguments = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArguments.Length == 1)
                {
                    commandArguments = commandArguments[0].Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    if (!forceSides.ContainsKey(commandArguments[0]))
                    {
                        forceSides.Add(commandArguments[0], new HashSet<string>());
                    }

                    bool existUser = false;
                    foreach (var side in forceSides)
                    {
                        if (side.Value.Contains(commandArguments[1]))
                        {
                            existUser = true;
                            break;
                        }
                    }

                    if (!existUser)
                    {
                        forceSides[commandArguments[0]].Add(commandArguments[1]);
                    }
                }
                else
                {
                    string currentUser = commandArguments[0];
                    string currentSide = commandArguments[1];

                    if (!forceSides.ContainsKey(currentSide))
                    {
                        forceSides.Add(currentSide, new HashSet<string>());
                    }

                    foreach (var kvp in forceSides)
                    {
                        if (kvp.Value.Contains(currentUser))
                        {
                            kvp.Value.Remove(currentUser); 
                        }
                    }

                    forceSides[currentSide].Add(currentUser);
                    Console.WriteLine($"{currentUser} joins the {currentSide} side!");
                }
            }

            foreach (KeyValuePair<string, HashSet<string>> side in forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (string user in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}