namespace WordCount
{
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordsFilePath = @"C:\temp\words.txt";
            string textFilePath = @"C:\temp\text.txt";
            string outputFilePath = @"output.txt";

            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words;

            using StreamReader reader = new StreamReader(wordsFilePath);
            {
                words = reader.ReadLine().Split(' ');
            }

            Regex regex = new Regex(@"\bquick\b|\bfault\b|\bis\b", RegexOptions.IgnoreCase);

            Dictionary<string, int> wordOccurences = new Dictionary<string, int>();
            using StreamReader textReader = new StreamReader(textFilePath);
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    MatchCollection matches = regex.Matches(line);
                    foreach (Match match in matches)
                    {
                        string currentMatch = match.Value.ToLower();

                        if (!wordOccurences.ContainsKey(currentMatch))
                        {
                            wordOccurences.Add(currentMatch, 0);
                        }

                        wordOccurences[currentMatch]++;
                    }
                }
            }

            using StreamWriter writer = new StreamWriter(outputFilePath);
            foreach (var kvp in wordOccurences.OrderByDescending(x => x.Value))
            {
                writer.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }
        }
    }
}