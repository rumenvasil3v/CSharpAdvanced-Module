/*
JennaMarbles joined The V-Logger
JennaMarbles followed Zoella
AmazingPhil joined The V-Logger
JennaMarbles followed AmazingPhil
Zoella joined The V-Logger
JennaMarbles followed Zoella
Christy followed Zoella
Zoella followed Christy
JacksGap joined The V-Logger
JacksGap followed JennaMarbles
PewDiePie joined The V-Logger
Zoella joined The V-Logger
PewDiePie followed AmazingPhil
AmazingPhil followed Zoella
Statistics
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] commandArguments = command.Split(' ');

                switch (commandArguments[1])
                {
                    case "joined":
                        string vloggerName = commandArguments[0];

                        Vlogger vlogger = new Vlogger(vloggerName, 0, 0);

                        if (!vloggers.ContainsKey(vlogger.Name))
                        {
                            vloggers.Add(vlogger.Name, vlogger);
                        }

                        break;
                    case "followed":
                        string vlooggerFollowingAnotherVlogger = commandArguments[0];
                        string vloggerFollowedByVlogger = commandArguments[2];

                        if (vlooggerFollowingAnotherVlogger != vloggerFollowedByVlogger
                            && vloggers.ContainsKey(vlooggerFollowingAnotherVlogger)
                            && vloggers.ContainsKey(vloggerFollowedByVlogger))
                        {
                            if (!vloggers[vloggerFollowedByVlogger].Followers.Contains(vlooggerFollowingAnotherVlogger))
                            {
                                vloggers[vloggerFollowedByVlogger].Followers.Add(vlooggerFollowingAnotherVlogger);
                                vloggers[vloggerFollowedByVlogger].CountOfFollowers++;
                                vloggers[vlooggerFollowingAnotherVlogger].CountOfFollowingPeople++;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

            Dictionary<string, Vlogger> allVloggers = vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.CountOfFollowingPeople).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
      
            KeyValuePair<string, Vlogger> mostFamousVlogger = vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.CountOfFollowingPeople).ToDictionary(x => x.Key, y => y.Value).First();

            int n = 1;
            foreach (var vlogger in allVloggers)
            {
                if (vlogger.Key == mostFamousVlogger.Key)
                {
                    Console.WriteLine($"{n++}. {vlogger.Key} : {vlogger.Value.CountOfFollowers} followers, {vlogger.Value.CountOfFollowingPeople} following");

                    foreach (var v in vlogger.Value.Followers)
                    {
                        Console.WriteLine($"*  {v}");
                    }
                    continue;
                }
                Console.WriteLine($"{n++}. {vlogger.Key} : {vlogger.Value.CountOfFollowers} followers, {vlogger.Value.CountOfFollowingPeople} following");
            }
        }
    }

    public class Vlogger
    {

        public Vlogger(string name, int countOfFollowers, int countOfFollowingPeople)
        {
            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.CountOfFollowers = countOfFollowers;
            this.CountOfFollowingPeople = countOfFollowingPeople;
        }

        public string Name { get; set; }

        public SortedSet<string> Followers { get; set; }

        public int CountOfFollowers { get; set; }

        public int CountOfFollowingPeople { get; set; }
    }
}
