namespace FolderSize
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\temp\Files\TestFolder";
            string outputPath = @"..\..\..\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sizeOfAllFiles = GetSizeOfAllFiles(folderPath);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{sizeOfAllFiles / 1024} KB");
            }
        }

        public static double GetSizeOfAllFiles(string folderPath)
        {
            double size = 0;

            foreach (var file in Directory.GetFiles(folderPath))
            {
                FileInfo fileInfo = new FileInfo(file);

                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.Length);
                size += fileInfo.Length;
            }

            foreach (var directory in Directory.GetDirectories(folderPath))
            {
                size += GetSizeOfAllFiles(directory);
            }

            return size;
        }
    }
}
