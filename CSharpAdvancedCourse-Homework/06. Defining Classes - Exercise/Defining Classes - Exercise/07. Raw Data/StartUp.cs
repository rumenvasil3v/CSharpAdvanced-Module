/*
4
ChevroletExpress 215 255 1200 flammable 2.5 1 2.4 2 2.7 1 2.8 1
ChevroletAstro 210 230 1000 flammable 2 1 1.9 2 1.7 3 2.1 1
DaciaDokker 230 275 1400 flammable 2.2 1 2.3 1 2.4 1 2 1
Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2
flammable
 */

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carInfo = Console
                    .ReadLine()
                    .Split(' ');

                string carModel = carInfo[0];

                int carEngineSpeed = int.Parse(carInfo[1]);
                int carEnginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(carEngineSpeed, carEnginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
                };

                Car car = new Car(carModel, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                PrintCarWithFragileCargo(cars);
            }
            else if (command == "flammable")
            {
                PrintCarWithFlammableCargo(cars);
            }
        }

        static void PrintCarWithFragileCargo(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.Cargo.Type == "fragile")
                {
                    foreach (Tire tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
        }

        static void PrintCarWithFlammableCargo(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.Cargo.Type == "flammable")
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}