using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {

        public Car(int weight, string color)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(weight, color)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");

            var engineDisplacement = this.Engine.Displacement == 0 ? "n/a" : $"{this.Engine.Displacement}";
            sb.AppendLine($"    Displacement: {engineDisplacement}");

            var engineEfficiency = this.Engine.Efficiency == string.Empty ? "n/a" : $"{this.Engine.Efficiency}";
            sb.AppendLine($"    Efficiency: {engineEfficiency}");

            var carWeight = this.Weight == 0 ? "n/a" : $"{this.Weight}";
            sb.AppendLine($"  Weight: {carWeight}");

            var carColor = this.Color == string.Empty ? "n/a" : $"{this.Color}";
            sb.Append($"  Color: {carColor}");

            return sb.ToString();
        }
    }
}
