using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int numberOfStudents = int.Parse(Console.ReadLine());
            AddingStudentsToDictionary(students, numberOfStudents);
            PrintDictionary(students);
        }

         static void PrintDictionary(Dictionary<string, List<decimal>> students)
        {
            foreach (KeyValuePair<string, List<decimal>> student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }

        static void AddingStudentsToDictionary(Dictionary<string, List<decimal>> students, int numberOfStudents)
        {
            for (int n = 0; n < numberOfStudents; n++)
            {
                string input = Console.ReadLine();
                string[] studentInformation = input.Split(' ');

                string studentName = studentInformation[0];
                decimal studentGrade = decimal.Parse(studentInformation[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(studentGrade);
            }
        }
    }
}
