using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"C:\temp\example.png";
            string bytesFilePath = @"C:\temp\bytes.txt";
            string outputPath = @"..\..\..\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            Dictionary<int, int> bytes = new Dictionary<int, int>();

            using (FileStream fileStreamRead = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] imageBuffer = new byte[fileStreamRead.Length];
                fileStreamRead.Read(imageBuffer, 0, imageBuffer.Length);
                using (StreamReader bytesReader = new StreamReader(bytesFilePath))
                {
                    string line;
                    while ((line = bytesReader.ReadLine()) != null)
                    {
                        if (!bytes.ContainsKey(int.Parse(line)))
                        {
                            bytes.Add(int.Parse(line), 0);
                        }
                    }
                }

                for (int n = 0; n < imageBuffer.Length; n++)
                {
                    if (bytes.ContainsKey(imageBuffer[n]))
                    {
                        bytes[imageBuffer[n]]++;
                    }
                }

                //using (FileStream fileStreamWriter = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                //{
                    byte[] buffer = new byte[bytes.Values.Sum()];

                    int index = 0;
                    for (int n = 0; n < imageBuffer.Length; n++)
                    {
                        if (bytes.ContainsKey(imageBuffer[n]))
                        {
                            buffer[index++] = imageBuffer[n];
                        }
                    }

                    //fileStreamWriter.Write(buffer, 0, buffer.Length);
                    File.WriteAllBytes(outputPath, buffer);
                //}
            }
        }
    }
}