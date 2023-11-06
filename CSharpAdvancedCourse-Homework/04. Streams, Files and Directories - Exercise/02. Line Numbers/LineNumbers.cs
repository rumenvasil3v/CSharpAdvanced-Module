namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            List<string> lines = new List<string>();
            int countOfLines = 1;
            foreach (string line in File.ReadAllLines(inputFilePath))
            {
                int countOfAllLettersInCurrentLine = 0;
                int countOfAllPunctuationMarks = 0;
                foreach (char character in line)
                {
                    if (char.IsLetter(character))
                    {
                        countOfAllLettersInCurrentLine++;
                    }
                    else if (char.IsPunctuation(character))
                    {
                        countOfAllPunctuationMarks++;
                    }
                }

                lines.Add($"Line {countOfLines++}: {line} ({countOfAllLettersInCurrentLine})({countOfAllPunctuationMarks})");
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
