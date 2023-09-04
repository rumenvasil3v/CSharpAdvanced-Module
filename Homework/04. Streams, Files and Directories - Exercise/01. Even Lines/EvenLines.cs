namespace EvenLines
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.Write(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            List<string> evenLines = new List<string>();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int currentLine = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (currentLine % 2 == 0)
                    {
                        evenLines.Add(line);
                    }

                    currentLine++;
                }
            }

            Regex regex = new Regex(@"[,.?\-\!]");

            StringBuilder sb = new StringBuilder();
            foreach (string line in evenLines)
            {
                string currentLine = regex.Replace(line, "@");

                string[] currentLineArray = currentLine.Split(' ');
                
                for (int n = currentLineArray.Length - 1; n >= 0; n--)
                {
                    if (n == 0)
                    {
                        sb.Append(currentLineArray[n]);
                        break;
                    }

                    sb.Append(currentLineArray[n] + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}