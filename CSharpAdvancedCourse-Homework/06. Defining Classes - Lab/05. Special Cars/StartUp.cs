using System.Net;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = Tire.AddTires();
            List<Engine> engines = Engine.AddEngines();
            List<Car> cars = new List<Car>();

            string command;
            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = command.Split(' ');

                // car info
                string carMake = carInfo[0];
                string carModel = carInfo[1];
                int yearCarProduced = int.Parse(carInfo[2]);
                double carFuelQuantity = double.Parse(carInfo[3]);
                double carFuelConsumption = double.Parse(carInfo[4]);

                // engine and tires car info
                int engineIndex = int.Parse(carInfo[5]);
                var carEngine = engines[engineIndex];

                int tireIndex = int.Parse(carInfo[6]);
                var carTires = tires[tireIndex];

                Car car = new Car(carMake, carModel, yearCarProduced, carFuelQuantity, carFuelConsumption, carEngine, carTires);

                cars.Add(car);
            }

            Func<Car, bool> funcYear = y => y.Year >= 2017;
            Func<Car, bool> funcHorsepower = h => h.Engine.HorsePower > 330;
            Func<Car, bool> funcTires = t => t.Tires.Sum(t => t.Pressure) >= 9 && t.Tires.Sum(t => t.Pressure) <= 10;

            var specialCars = cars.Where(funcYear).Where(funcHorsepower).Where(funcTires);

            foreach (var specialCar in specialCars)
            {
                specialCar.DriveTwentyKilometers(20);

                string specialCarInfo = specialCar.WhoAmI();
                Console.WriteLine(specialCarInfo);
            }
        }
    }
}