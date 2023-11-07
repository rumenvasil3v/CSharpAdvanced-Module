using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private const string NumberOfToppingsOnPizzaException = "Number of toppings should be in range [0..10].";
        private const string PizzaNameException = "Pizza name should be between 1 and 15 symbols.";
        private const double MaxNumberOfToppings = 10;
        private const double MaxCharactersInPizzaName = 15;

        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                IsNameOfThePizzaInvalid(value);
                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get => this.numberOfToppings;
            private set
            {
                AreNumberOfToppingsGreaterThanTen(value);
                this.numberOfToppings = value;
            }
        }

        public double TotalCalories => CalculateTotalCalories();

        public IReadOnlyCollection<Topping> Toppings => toppings;

        public void AddTopping(Topping topping)
        {
            this.NumberOfToppings++;
            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:F2} Calories.";
        }

        private double CalculateTotalCalories()
        {
            //double totalCalories = 0;
            //totalCalories += this.dough.TotalCalories;

            //foreach (var topping in this.toppings)
            //{
            //    totalCalories += topping.TotalCalories;
            //}

            return this.dough.TotalCalories + this.toppings.Sum(x => x.TotalCalories);
        }

        private void AreNumberOfToppingsGreaterThanTen(int value)
        {
            if (value > MaxNumberOfToppings)
            {
                throw new ArgumentException(NumberOfToppingsOnPizzaException);
            }
        }

        private void IsNameOfThePizzaInvalid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > MaxCharactersInPizzaName)
            {
                throw new ArgumentException(PizzaNameException);
            }
        }
    }
}