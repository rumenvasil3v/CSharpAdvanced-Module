using System.Numerics;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[numberOfRows][];

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

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int currentRow = row; currentRow < row + 2; currentRow++)
                    {
                        for (int col = 0; col < jaggedArray[currentRow].Length; col++)
                        {
                            jaggedArray[currentRow][col] /= 2;
                        }
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArguments = command.Split(' ');

                int currentRow = 0;
                int currentColumn = 0;
                int currentValue = 0;
                switch (commandArguments[0])
                {
                    case "Add":
                        currentRow = int.Parse(commandArguments[1]);
                        currentColumn = int.Parse(commandArguments[2]);

                        if (currentRow >= 0 && currentRow < jaggedArray.Length 
                            && currentColumn >= 0 && currentColumn < jaggedArray[currentRow].Length)
                        {
                            currentValue = int.Parse(commandArguments[3]);
                            jaggedArray[currentRow][currentColumn] += currentValue;
                        }
                        break;
                    case "Subtract":
                        currentRow = int.Parse(commandArguments[1]);
                        currentColumn = int.Parse(commandArguments[2]);

                        if (currentRow >= 0 && currentRow < jaggedArray.Length
                            && currentColumn >= 0 && currentColumn < jaggedArray[currentRow].Length)
                        {
                            currentValue = int.Parse(commandArguments[3]);
                            jaggedArray[currentRow][currentColumn] -= currentValue;
                        }
                        break;
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}