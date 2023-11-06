using System.Security.Cryptography;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRows][];

            AddElementsToJaggedArray(jaggedArray);

            ModificateJaggedArray(jaggedArray);
        }

        static void AddElementsToJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string elements = Console.ReadLine();
                string[] jaggedArrayElements = elements.Split(' ');
                jaggedArray[row] = new int[jaggedArrayElements.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(jaggedArrayElements[col]);
                }
            }
        }

        static void ModificateJaggedArray(int[][] jaggedArray)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArguments = command.Split(' ');

                switch (commandArguments[0])
                {
                    case "Add":
                        AddValueToCurrentValue(jaggedArray, commandArguments);
                        break;
                    case "Subtract":
                        SubtractValueFromCurrentValue(jaggedArray, commandArguments);
                        break;
                }
            }

            PrintFinalConditionOfJaggedArray(jaggedArray);
        }

        static void AddValueToCurrentValue(int[][] jaggedArray, string[] commandArguments)
        {
            int rowToAddValue = int.Parse(commandArguments[1]);
            int colToAddValue = int.Parse(commandArguments[2]);

            int valueToAdd = int.Parse(commandArguments[3]);

            if (rowToAddValue >= 0 && rowToAddValue <= jaggedArray.Length - 1 && colToAddValue >= 0 && colToAddValue <= jaggedArray[rowToAddValue].Length - 1)
            {

                jaggedArray[rowToAddValue][colToAddValue] += valueToAdd;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
        }

        static void SubtractValueFromCurrentValue(int[][] jaggedArray, string[] commandArguments)
        {
            int rowToSubtractValue = int.Parse(commandArguments[1]);
            int colToSubtractValue = int.Parse(commandArguments[2]);

            int valueToSubtract = int.Parse(commandArguments[3]);

            if (rowToSubtractValue >= 0 && rowToSubtractValue <= jaggedArray.Length - 1 && colToSubtractValue >= 0 && colToSubtractValue <= jaggedArray[rowToSubtractValue].Length - 1)
            {

                jaggedArray[rowToSubtractValue][colToSubtractValue] -= valueToSubtract;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
        }

        static void PrintFinalConditionOfJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(' ', jaggedArray[row]));
            }
        }
    }
}