namespace demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name = "Niki";
            string number = "0898877878";
            string homePlace = "Sofia";

            Func<string, string, string, string> func = MyMethod;
            string value = func(name, number, homePlace);
            Console.WriteLine(value);

            value = HighOrderMethod(personName: "Pesho", personNumber: "087 654 3214", personHomePlace: "Veliko Tarnovo", func);
            Console.WriteLine(value);
        }

        static string MyMethod(string personName, string personNumber, string homePlace)
        {
            return $"{personName} -> {personNumber} from {homePlace}";
        }

        static string HighOrderMethod(string personName, string personNumber, string personHomePlace, Func<string, string, string, string> func)
        {
            return func(personName, personNumber, personHomePlace);
        }
    }
}