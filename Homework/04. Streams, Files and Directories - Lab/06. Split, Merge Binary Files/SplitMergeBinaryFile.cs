namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"C:\temp\example.png";
            string joinedFilePath = @"..\..\..\example-joined.png";
            string partOnePath = @"..\..\..\part-1.bin";
            string partTwoPath = @"..\..\..\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream fileStreamReader = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStreamReader.Length];

                fileStreamReader.Read(buffer, 0, buffer.Length);

                double partSize = buffer.Length / 2.0;

                double floorNumber = Math.Floor(partSize);
                double ceilingNumber = Math.Ceiling(partSize);
                using (FileStream partOneFileStream = new FileStream(partOneFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] partOneBuffer = new byte[(int)floorNumber];

                    int index = 0;
                    for (int n = 0; n < floorNumber; n++)
                    {
                        partOneBuffer[index++] = buffer[n];
                    }

                    partOneFileStream.Write(partOneBuffer, 0, partOneBuffer.Length);
                }

                using (FileStream partTwoFileStream = new FileStream(partTwoFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] partTwoBuffer = new byte[(int)ceilingNumber];

                    int index = 0;
                    for (int n = (int)floorNumber; n < (int)ceilingNumber + floorNumber; n++)
                    {
                        partTwoBuffer[index++] = buffer[n];
                    }

                    partTwoFileStream.Write(partTwoBuffer, 0, partTwoBuffer.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream fileStream = new FileStream(joinedFilePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (FileStream fileStreamPartOne = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] bufferPartOne = new byte[fileStreamPartOne.Length];

                    fileStreamPartOne.Read(bufferPartOne, 0, bufferPartOne.Length);
                    using (FileStream fileStreamPartTwo = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer = new byte[fileStreamPartOne.Length + fileStreamPartTwo.Length];

                        byte[] bufferPartTwo = new byte[fileStreamPartTwo.Length];
                        fileStreamPartTwo.Read(bufferPartTwo, 0, bufferPartTwo.Length);

                        buffer = bufferPartOne.Concat(bufferPartTwo).ToArray();
                        fileStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}