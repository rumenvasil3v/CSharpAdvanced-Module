namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\temp\input.txt";
            string outputFilePath = @"output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using StreamReader reader = new StreamReader(inputFilePath);
            {
                int numberLine = 1;
                string line;

                using StreamWriter writer = new StreamWriter(outputFilePath);
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine("{0}. {1}", numberLine, line);
                        numberLine++;
                    }
                }
            }
        }
    }
}