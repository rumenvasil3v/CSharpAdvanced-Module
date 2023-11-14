using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25F;

        private int horsePower;
        private double fuel;

        protected Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get { return this.horsePower; } set { this.horsePower = value; } }

        public double Fuel { get { return this.fuel;  } set { this.fuel = value; } }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers) => this.Fuel -= this.FuelConsumption * kilometers;
    }
}