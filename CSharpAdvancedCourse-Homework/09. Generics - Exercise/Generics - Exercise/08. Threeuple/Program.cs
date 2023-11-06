namespace _08._Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(" ");
            string town = string.Join(" ", firstInput.Skip(3));
            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2], town);
            Console.WriteLine($"{firstTuple.FirstItem} -> {firstTuple.SecondItem} -> {firstTuple.ThirdItem}");

            string[] secondInput = Console.ReadLine().Split(" ");
            bool drunkOrNot = false;
            if (secondInput[2] == "drunk")
            {
                drunkOrNot = true;
            }

            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>($"{secondInput[0]}", int.Parse(secondInput[1]), drunkOrNot);
            Console.WriteLine($"{secondTuple.FirstItem} -> {secondTuple.SecondItem} -> {secondTuple.ThirdItem}");

            string[] thirdInput = Console.ReadLine().Split(" ");
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1]), thirdInput[2]);
            Console.WriteLine($"{thirdTuple.FirstItem} -> {thirdTuple.SecondItem} -> {thirdTuple.ThirdItem}");
        }
    }
}