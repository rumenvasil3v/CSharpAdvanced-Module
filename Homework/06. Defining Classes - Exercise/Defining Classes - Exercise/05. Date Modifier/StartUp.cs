namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            dateModifier.CalculateDifferenceBetweenTwoDates(firstDate, secondDate);
        }
    }
}