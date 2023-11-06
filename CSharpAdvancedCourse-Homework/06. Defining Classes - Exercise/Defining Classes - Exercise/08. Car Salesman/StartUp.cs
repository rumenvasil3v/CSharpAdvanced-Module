namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = GetEngines();

            List<Car> cars = GetCars(engines);

            PrintCars(cars);
        }

        static void PrintCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        static List<Engine> GetEngines()
        {
            List<Engine> engines = new List<Engine>();

            int numberOfEngines = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfEngines; n++)
            {
                string[] engineInfo = Console
                    .ReadLine()
                    .Split(' ');

                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);

                string engineEfficiency = string.Empty;
                if (engineInfo.Length > 2)
                {
                    bool isItTrue = int.TryParse(engineInfo[2], out int engineDisplacement);
                    if (isItTrue)
                    {
                        if (engineInfo.Length > 3)
                        {
                            engineEfficiency = engineInfo[3];
                        }
                    }
                    else
                    {
                        engineEfficiency = engineInfo[2];
                    }

                    Engine engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);

                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(engineModel, enginePower, 0, string.Empty);

                    engines.Add(engine);
                }
            }

            return engines;
        }

        static List<Car> GetCars(List<Engine> engines)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carInfo = Console
                    .ReadLine()
                    .Split(' ');

                string carModel = carInfo[0];

                string carEngine = carInfo[1];
                Engine engine = engines.FirstOrDefault(e => e.Model == carEngine);

                string carColor = string.Empty;
                if (carInfo.Length > 2)
                {
                    bool isIsTrue = int.TryParse(carInfo[2], out int carWeight);
                    if (isIsTrue)
                    {
                        if (carInfo.Length > 3)
                        {
                            carColor = carInfo[3];
                        }
                    }
                    else
                    {
                        carColor = carInfo[2];
                    }

                    Car car = new Car(carModel, engine, carWeight, carColor);
                    cars.Add(car);
                }
                else
                {
                    Car car = new Car(carModel, engine, 0, string.Empty);
                    cars.Add(car);
                }
            }

            return cars;
        }
    }
}