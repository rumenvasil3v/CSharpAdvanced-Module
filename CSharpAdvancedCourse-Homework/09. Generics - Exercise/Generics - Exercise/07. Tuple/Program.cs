namespace _07._Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string personInformation = Console.ReadLine();
            string[] personArguments = personInformation.Split(" ").ToArray();
            string personName = string.Join(" ", personArguments.Take(2));
            string personAdress = personArguments[2];

            CustomTuple<string, string> person = new CustomTuple<string, string>(personName, personAdress);
            Console.WriteLine($"{person.FirstItem} -> {person.SecondItem}");

            string[] personPossibility = Console.ReadLine().Split(" ");
            string secondPersonName = personPossibility[0];
            int litersOfBeerHeCanDrink = int.Parse(personPossibility[1]);

            CustomTuple<string, int> secondPerson = new CustomTuple<string, int>(secondPersonName, litersOfBeerHeCanDrink);
            Console.WriteLine($"{secondPerson.FirstItem} -> {secondPerson.SecondItem}");

            string[] numbers = Console.ReadLine().Split(" ");
            int integer = int.Parse(numbers[0]);
            double decimalNumber = double.Parse(numbers[1]);

            CustomTuple<int, double> randomNumbers = new CustomTuple<int, double>(integer, decimalNumber);
            Console.WriteLine($"{randomNumbers.FirstItem} -> {randomNumbers.SecondItem}");
        }
    }
}