namespace CopyBinaryFile
{
    using System;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream fileStreamBytesReader = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStreamBytesReader.Length];
                fileStreamBytesReader.Read(buffer, 0, buffer.Length);

                using (FileStream fileStreamBytesWriter = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    fileStreamBytesWriter.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
