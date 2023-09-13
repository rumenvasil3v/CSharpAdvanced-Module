using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire() 
        {
            this.Year = 2023;
            this.Pressure = 0;
        }

        public Tire(int year, double pressure) : this()
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year 
        { 
            get
            { 
                return this.year;
            } 
            set 
            { 
                this.year = value; 
            } 
        }

        public double Pressure 
        { 
            get
            { 
                return this.pressure; 
            } 
            set 
            { 
                this.pressure = value;
            } 
        }
    }
}
