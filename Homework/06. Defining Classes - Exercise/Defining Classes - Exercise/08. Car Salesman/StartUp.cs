namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
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
                int engineDisplacement = int.Parse(engineInfo[2]);
                string engineEfficiency = engineInfo[3];

                Engine engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carInfo = Console
                    .ReadLine()
                    .Split(' ');


            }
        }
    }
}