/*
Peter-Java-84
George-C#-70
George-C#-100
Sam-C#-94
exam finished

 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            Dictionary<string, int> users = new Dictionary<string, int>();

            RecordInformationAboutSubmissions(languageSubmissions, users);

            PrintEachUser(users);
            PrintEachLanguage(languageSubmissions);
        }

        static void PrintEachLanguage(Dictionary<string, int> languageSubmissions)
        {
            Console.WriteLine("Submissions:");
            foreach (KeyValuePair<string, int> language in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }

        static void RecordInformationAboutSubmissions(Dictionary<string, int> languageSubmissions, Dictionary<string, int> users)
        {
            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] submissionArguments = command.Split('-');

                string user = submissionArguments[0];

                switch (submissionArguments[1])
                {
                    case "banned":

                        users.Remove(user);
                        break;
                    default:
                        string currentLanguageSubmission = submissionArguments[1];
                        int pointsForExamExercise = int.Parse(submissionArguments[2]);

                        if (!users.ContainsKey(user))
                        {
                            users.Add(user, 0);
                        }

                        if (users[user] < pointsForExamExercise)
                        {
                            users[user] = pointsForExamExercise;
                        }

                        if (!languageSubmissions.ContainsKey(currentLanguageSubmission))
                        {
                            languageSubmissions.Add(currentLanguageSubmission, 0);
                        }

                        languageSubmissions[currentLanguageSubmission]++;

                        break;
                }

            }
        }

        static void PrintEachUser(Dictionary<string, int> users)
        {
            Console.WriteLine("Results:");
            foreach (var user in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
        }
    }
}
