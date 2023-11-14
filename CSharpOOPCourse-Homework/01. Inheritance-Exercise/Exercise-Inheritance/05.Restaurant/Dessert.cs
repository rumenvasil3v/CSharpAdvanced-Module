﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Dessert : Food
    {
        private double calories;

        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.Calories = calories;
        }

        public double Calories { get { return this.calories; } set { this.calories = value; } }
    }
}
