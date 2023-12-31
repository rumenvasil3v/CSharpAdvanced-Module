﻿namespace DirectoryTraversal
{
    using System;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\juice.txt";

            Dictionary<string, Dictionary<string, double>> reportContent = TraverseDirectory(path);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static Dictionary<string, Dictionary<string, double>> TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, Dictionary<string, double>> extensions = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in Directory.GetFiles(inputFolderPath))
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                if (!extensions[fileInfo.Extension].ContainsKey(fileInfo.Name))
                {
                    extensions[fileInfo.Extension].Add(fileInfo.Name, fileInfo.Length);
                }
            }

            return extensions;
        }

        public static void WriteReportToDesktop(
            Dictionary<string, Dictionary<string, double>> textContent,
            string reportFileName
        )
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var kvp in textContent.OrderByDescending(x => x.Value.Count)
                                                   .ThenBy(x => x.Key))
                    {
                        writer.WriteLine($"{kvp.Key}");

                        foreach (var file in kvp.Value.OrderBy(x => x.Value))
                        {
                            writer.WriteLine($"--{file.Key} - {file.Value / 1024.0:F2}kb");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception throw!!!");
            }
        }
    }
}