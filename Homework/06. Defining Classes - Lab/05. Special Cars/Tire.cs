using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire()
        {
            this.Year = 2023;
            this.Pressure = 0;
        }

        public Tire(int year, double pressure) : this()
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }

        public static List<Tire[]> AddTires()
        {
            List<Tire[]> tires = new List<Tire[]>();

            int currentTireGroup = 0;

            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = command.Split(' ');

                tires.Add(new Tire[4]);

                int skip = 0;
                for (int n = 0; n < 4; n++)
                {
                    string[] currenTire = tireInfo.Skip(skip).Take(2).ToArray();

                    int yearTireProduced = int.Parse(currenTire[0]);
                    double pressureInTire = double.Parse(currenTire[1]);

                    Tire tire = new Tire(yearTireProduced, pressureInTire);
                    tires[currentTireGroup][n] = tire;

                    skip += 2;
                }

                currentTireGroup++;
            }

            return tires;
        }
    }
}