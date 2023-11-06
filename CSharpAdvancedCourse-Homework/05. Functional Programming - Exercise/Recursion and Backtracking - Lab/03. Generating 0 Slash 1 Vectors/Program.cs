namespace _03._Generating_0_Slash_1_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            GenerateVectors(array, 0);
        }

        static void GenerateVectors(int[] array, int number)
        {
            if (number == array.Length)
            {
                Console.WriteLine(string.Join("", array));
                return;
            }

            for (int n = 0; n < 2; n++)
            {
                array[number] = n;

                GenerateVectors(array, number + 1);
            }
        }
    }
}