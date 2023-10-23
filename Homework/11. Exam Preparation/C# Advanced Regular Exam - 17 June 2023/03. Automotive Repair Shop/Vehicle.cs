using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        private string vin;
        private int mileage;
        private string damage;

        public Vehicle(string vin, int mileage, string damage)
        {
            this.VIN = vin;
            this.Mileage = mileage;
            this.Damage = damage;
        }

        public string VIN { get { return this.vin; } set { this.vin = value; } }

        public int Mileage { get { return this.mileage; } set { this.mileage = value; } }

        public string Damage { get { return this.damage; } set { this.damage = value; } }

        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
