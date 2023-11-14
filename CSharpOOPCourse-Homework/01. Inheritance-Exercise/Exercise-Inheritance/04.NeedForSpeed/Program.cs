namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sport = new(300, 100);
            Console.WriteLine(sport.FuelConsumption);

            sport.Drive(20);
            sport.Drive(10);
        }
    }
}
