namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());

            if (age < 16)
            {
                Child child = new(name, age);
                Console.WriteLine(child.ToString());
            }
            else
            {
                Person person = new(name, age);
                Console.WriteLine(person.ToString());
            }
        }
    }
}