/*
3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End
 */

using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = AddCars();

            TravelDistanceForEachCar(cars);
            PrintCars(cars);
        }

        static void PrintCars(Dictionary<string, Car> cars)
        {
            foreach (KeyValuePair<string, Car> car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.Key, car.Value.FuelAmount, car.Value.TravelledDistance);
            }
        }

        static void TravelDistanceForEachCar(Dictionary<string, Car> cars)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArguments = command.Split(' ');

                string carModel = commandArguments[1];
                int kilometersToTravel = int.Parse(commandArguments[2]);

                cars[carModel].CheckIfCarCanTravelThatDistance(kilometersToTravel);
            }
        }

        static Dictionary<string, Car> AddCars()
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carInfo = Console
                    .ReadLine()
                    .Split(' ');

                string carModel = carInfo[0];
                double carFuelAmount = double.Parse(carInfo[1]);
                double carFuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(carModel, carFuelAmount, carFuelConsumptionPerKilometer);

                if (!cars.ContainsKey(car.Model))
                {
                    cars.Add(car.Model, car);
                }
            }

            return cars;
        }
    }
}