/*
1991
2.2
2001
2.3
1777
1.3
2023
2.3
 */

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4];

            for (int n = 0; n < tires.Length; n++)
            {
                tires[n] = new Tire();

                Console.Write("Year tire produced: ");
                tires[n].Year = int.Parse(Console.ReadLine());

                Console.Write("How much air does tire have: ");
                tires[n].Pressure = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");

            Engine engine = new Engine();

            foreach (Tire tire in tires)
            {
                Console.WriteLine($"Tire produced: {tire.Year}; Pressure: {tire.Pressure}");
            }

            Console.WriteLine("-------------------------------------");

            Car car = new Car("Maserati", "Levante", 2023, 60, 0.1, engine, tires);

            string carResult = car.WhoAmI();
            Console.WriteLine(carResult);
        }
    }
}