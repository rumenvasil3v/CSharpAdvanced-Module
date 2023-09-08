namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string zipArchiveFilePath = @"..\..\..\archive.zip";
            string outputFilePath = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFilePath, zipArchiveFilePath);
            ExtractFileFromArchive(zipArchiveFilePath, inputFilePath, outputFilePath);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            string textFilePath = @"..\..\..\text.txt";
            string textFileName = Path.GetFileName(textFilePath);

            using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                string fileName = Path.GetFileName(inputFilePath);
                archive.CreateEntryFromFile(inputFilePath, fileName);
                archive.CreateEntryFromFile(textFilePath, textFileName);
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string inputFilePath, string outputFilePath)
        {
            using (var archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                //foreach (var zip in archive.Entries)
                //{
                //    zip.ExtractToFile(outputFilePath);
                //}

                string fileName = Path.GetFileName(inputFilePath);
                ZipArchiveEntry entry = archive.GetEntry(fileName);
                entry.ExtractToFile(outputFilePath);
            }
        }
    }
}