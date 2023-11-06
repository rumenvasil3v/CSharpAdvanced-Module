using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> contests = new Dictionary<string, string>();

            AddingContestsToDictionary(contests);
            AddingCandidatesWithPointsForContest(candidates, contests);
            FindBestCandidateAndPrintAllCandidates(candidates);
        }

        static void FindBestCandidateAndPrintAllCandidates(Dictionary<string, Dictionary<string, int>> candidates)
        {
            string bestCandidateName = string.Empty;
            int bestCandidatePoints = int.MinValue;
            foreach (var candidate in candidates)
            {
                int currentCandidatePoints = candidate.Value.Values.Sum();

                if (currentCandidatePoints > bestCandidatePoints)
                {
                    bestCandidatePoints = currentCandidatePoints;
                    bestCandidateName = candidate.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var candidate in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);

                foreach (var candidatePoints in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {candidatePoints.Key} -> {candidatePoints.Value}");
                }
            }
        }

        static void AddingContestsToDictionary(Dictionary<string, string> contests)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] contestArguments = command.Split(':');

                string contest = contestArguments[0];
                string passwordForContest = contestArguments[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, passwordForContest);
                }
            }
        }

        static void AddingCandidatesWithPointsForContest(Dictionary<string, Dictionary<string, int>> candidates, Dictionary<string, string> contests)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] currentCandidateContestArguments = command.Split("=>");

                string currentContest = currentCandidateContestArguments[0];
                string currentPassword = currentCandidateContestArguments[1];
                string currentUsername = currentCandidateContestArguments[2];
                int currentPointsForCurrentContest = int.Parse(currentCandidateContestArguments[3]);

                if (contests.ContainsKey(currentContest) && contests[currentContest] == currentPassword)
                {
                    if (!candidates.ContainsKey(currentUsername))
                    {
                        candidates.Add(currentUsername, new Dictionary<string, int>() { { currentContest, currentPointsForCurrentContest } });
                        continue;
                    }

                    if (candidates[currentUsername].ContainsKey(currentContest))
                    {
                        if (candidates[currentUsername][currentContest] < currentPointsForCurrentContest)
                        {
                            candidates[currentUsername][currentContest] = currentPointsForCurrentContest;
                        }
                    }
                    else
                    {
                        candidates[currentUsername].Add(currentContest, currentPointsForCurrentContest);
                    }
                }
            }
        }
    }
}
