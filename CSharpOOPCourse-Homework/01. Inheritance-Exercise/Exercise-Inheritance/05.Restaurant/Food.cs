using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Food : Product
    {
        private double grams;

        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.Grams = grams;
        }

        public double Grams { get { return this.grams; } set { this.grams = value; } }
    }
}