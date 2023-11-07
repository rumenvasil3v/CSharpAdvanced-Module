/*
Pizza 
Dough White Chewy 100
Topping Sauce 20
Topping Cheese 50
Topping Cheese 40
Topping Meat 10
Topping Sauce 10
Topping Cheese 30
Topping Cheese 40
Topping Meat 20
Topping Sauce 30
Topping Cheese 25
Topping Cheese 40
Topping Meat 40
END
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private const string ToppingTypeExceptionFirstPart = $"Cannot place ";
        private const string ToppingTypeExceptionSecondPart = $" on top of your pizza.";
        private const string ToppingWeightException = $" weight should be in the range [1..50].";
        private const double CaloriesPerGram = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 50;

        private string type;
        private double weight;
        private double typeCalories;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                value = value.ToString().ToLower();

                IsTypeInvalidValue(value);
                
                value = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {     
                IsWeightInvalidValue(value);
                this.weight = value;
            }
        }

        public double TotalCalories => CalculateCaloriesPerGram();

        private double CalculateCaloriesPerGram()
        {
            switch (this.Type)
            {
                case "Meat":
                    this.typeCalories = 1.2;
                    break;
                case "Veggies":
                    this.typeCalories = 0.8;
                    break;
                case "Cheese":
                    this.typeCalories = 1.1;
                    break;
                case "Sauce":
                    this.typeCalories = 0.9;
                    break;
            }

            return CaloriesPerGram * this.Weight * this.typeCalories;
        }

        private void IsTypeInvalidValue(string value)
        {
            if(value != "meat" && value != "cheese" && value != "veggies" && value != "sauce")
            {
                value = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                throw new ArgumentException(ToppingTypeExceptionFirstPart + value + ToppingTypeExceptionSecondPart);
            }
        }

        private void IsWeightInvalidValue(double value)
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException(this.Type + ToppingWeightException);
            }
        }
    }
}