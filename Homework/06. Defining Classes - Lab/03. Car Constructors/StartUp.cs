namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            string resultOfFirstCar = firstCar.WhoAmI();
            Console.WriteLine(resultOfFirstCar);

            Console.WriteLine("------------");

            Car secondCar = new Car(make, model, year);
            string resultOfSecondCar = secondCar.WhoAmI();
            Console.WriteLine(resultOfSecondCar);

            Console.WriteLine("------------");

            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            string resultOfThirdCar = thirdCar.WhoAmI();
            Console.WriteLine(resultOfThirdCar);
        }
    }
} 