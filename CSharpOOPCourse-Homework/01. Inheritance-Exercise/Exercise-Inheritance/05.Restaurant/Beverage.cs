using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Beverage : Product
    {
        private double milliliters;

        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters { get { return this.milliliters; } private set { this.milliliters = value; } }
    }
}