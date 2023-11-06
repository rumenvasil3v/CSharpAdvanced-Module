namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int n = 0; n < numberOfPeople; n++)
            {
                string[] personInfo = Console
                    .ReadLine()
                    .Split(' ');

                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);

                Person person = new Person(personName, personAge);

                family.AddMember(person);
            }

            Person oldestMemberInFamily = family.GetOldestMember();
            Console.WriteLine($"{oldestMemberInFamily.Name} {oldestMemberInFamily.Age}");
        }
    }
}