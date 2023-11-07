using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const string DoughWeightException = "Dough weight should be in the range [1..200].";
        private const string InvalidTypeOfDoughException = "Invalid type of dough.";
        private const double CaloriesPerGram = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private double doughWeight;
        private double flourTypeCalories;
        private double bakingTechniqueCalories;

        public Dough(string flourType, string bakingTechnique, double doughWeight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.DoughWeight = doughWeight;
        }

        public double TotalCalories => CalculateCaloriesPerGram();

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                value = value.ToString().ToLower();

                IsFlourTypeInvalid(value);

                value = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                value = value.ToString().ToLower();

                IsBakingTechniqueInvalid(value);

                value = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                this.bakingTechnique = value;
            }
        }

        public double DoughWeight
        {
            get => this.doughWeight;
            private set
            {
                IsDoughWeightInvalid(value);
                this.doughWeight = value;
            }
        }

        private double CalculateCaloriesPerGram()
        {
            switch (this.FlourType)
            {
                case "White":
                    this.flourTypeCalories = 1.5;
                    break;
                case "Wholegrain":
                    this.flourTypeCalories = 1.0;
                    break;
            }

            switch (BakingTechnique)
            {
                case "Crispy":
                    this.bakingTechniqueCalories = 0.9;
                    break;
                case "Chewy":
                    this.bakingTechniqueCalories = 1.1;
                    break;
                case "Homemade":
                    this.bakingTechniqueCalories = 1.0;
                    break;
            }

            return CaloriesPerGram * this.DoughWeight * this.flourTypeCalories * this.bakingTechniqueCalories;
        }

        private void IsDoughWeightInvalid(double value)
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException(DoughWeightException);
            }
        }

        private void IsBakingTechniqueInvalid(string value)
        {
            if (value != "crispy" && value != "chewy" && value != "homemade")
            {
                throw new ArgumentException(InvalidTypeOfDoughException);
            }
        }

        private void IsFlourTypeInvalid(string value)
        {
            if (value != "white" && value != "wholegrain")
            {
                throw new ArgumentException(InvalidTypeOfDoughException);
            }
        }
    }
}