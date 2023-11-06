namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse);

            string command = Console.ReadLine();
            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                Func<int, int> func = ArithmeticOperation(command);

                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(func);
                        break;
                    case "multiply":
                        numbers = numbers.Select(func);
                        break;
                    case "subtract":
                        numbers = numbers.Select(func);
                        break;
                    case "print":
                        foreach (var item in numbers)
                        {
                            Console.Write(func(item) + " ");
                        }

                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;

                }

                command = Console.ReadLine();
            }
        }

        static Func<int, int> ArithmeticOperation(string command)
        {
            switch (command)
            {
                case "add":
                    return n => n + 1;
                case "multiply":
                    return n => n * 2;
                case "subtract":
                    return n => n - 1;
                case "print":
                    return n => n;
                default:
                    throw new ArgumentException(command);
            }
        }
    }
}