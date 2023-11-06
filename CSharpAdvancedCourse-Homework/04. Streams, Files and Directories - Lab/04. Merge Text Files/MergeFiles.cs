namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            string firstInputFilePath = @"C:\temp\input1.txt";
            string secondInputFilePath = @"C:\temp\input2.txt";
            string outputFilePath = "output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader firstReader = new StreamReader(firstInputFilePath);
            {
                using StreamReader secondReader = new StreamReader(secondInputFilePath);
                {
                    using StreamWriter writer = new StreamWriter(outputFilePath);
                    {
                        string firstPathLine;
                        while ((firstPathLine = firstReader.ReadLine()) != null)
                        {
                            writer.WriteLine(firstPathLine);

                            string secondPathLine;
                            while ((secondPathLine = secondReader.ReadLine()) != null)
                            {
                                writer.WriteLine(secondPathLine);
                                break;
                            }
                        }

                        string leftLines;
                        while ((leftLines = secondReader.ReadLine()) != null)
                        {
                            writer.WriteLine(leftLines);
                        }
                    }
                }
            }
        }
    }
}