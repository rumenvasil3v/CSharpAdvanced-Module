using System.Security.Cryptography;
using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = @"..\..\..\input.txt";
            string output = @"..\..\..\output.bin";

            using (FileStream file = new FileStream(input, FileMode.Open))
            {
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);

                byte[] en = Encoding.Unicode.GetBytes(new char[] {'К', 'А', 'Б'});

                var a = 0;
                using FileStream write = new FileStream(output, FileMode.Create);

                write.Write(en, 0, en.Length);
            }
        }
    }
}