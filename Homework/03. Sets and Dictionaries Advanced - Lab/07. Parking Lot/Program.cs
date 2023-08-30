using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string command;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] carArguments = command.Split(", ");

                string direction = carArguments[0];
                string carNumber = carArguments[1];

                switch (direction)
                {
                    case "IN":
                        carNumbers.Add(carNumber);
                        break;
                    case "OUT":
                        carNumbers.Remove(carNumber);
                        break;
                }
            }

            if (carNumbers.Count > 0)
            {

                foreach (string carNumber in carNumbers)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}