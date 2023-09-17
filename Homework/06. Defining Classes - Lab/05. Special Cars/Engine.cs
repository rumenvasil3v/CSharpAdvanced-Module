using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine()
        {
            this.HorsePower = 777;
            this.CubicCapacity = 3.0;
        }

        public Engine(int horsePower, double cubicCapacity) : this()
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            set
            {
                this.cubicCapacity = value;
            }
        }

        public static List<Engine> AddEngines()
        {
            var engines = new List<Engine>();

            string command;
            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = command.Split(' ');

                int horsePowerForEngine = int.Parse(engineInfo[0]);
                double cubicCapacityForEngine = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePowerForEngine, cubicCapacityForEngine);

                engines.Add(engine);
            }

            return engines;
        }
    }
}