namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\temp\input.txt";
            string outputFilePath = @"output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using StreamReader reader = new StreamReader(inputFilePath);

            string line = reader.ReadLine();

            int index = 0;
            using StreamWriter writer = new StreamWriter(outputFilePath);
            while (line != null)
            {
                if (index % 2 == 1)
                {
                    writer.WriteLine(line);
                }

                index++;
                line = reader.ReadLine();
            }
        }
    }
}