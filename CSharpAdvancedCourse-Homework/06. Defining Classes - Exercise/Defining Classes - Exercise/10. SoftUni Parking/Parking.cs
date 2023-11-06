using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private static int capacity;
        private int count;

        public Parking(int capacity)
        {
            this.Cars = new Dictionary<string, Car>();
            Capacity = capacity;
        }

        public Dictionary<string, Car> Cars
        {
            get
            {
                return this.cars;
            }
            set
            {
                this.cars = value;
            }
        }

        public static int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        public string AddCar(Car car)
        {
            if (!this.Cars.ContainsKey(car.RegistrationNumber))
            {
                if (this.Cars.Count >= Capacity)
                {
                    return "Parking is full!";
                }

                this.Cars.Add(car.RegistrationNumber, car);
                this.Count++;
                
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return "Car with that registration number, already exists!";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.Cars.ContainsKey(registrationNumber))
            {
                this.Cars.Remove(registrationNumber);
                this.Count--;

                return $"Successfully removed {registrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNumber)
        {
            return this.Cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string number in registrationNumbers)
            {
                if (this.Cars.ContainsKey(number))
                {
                    this.Cars.Remove(number);
                    this.Count--;
                }
            }
        }
    }
}
