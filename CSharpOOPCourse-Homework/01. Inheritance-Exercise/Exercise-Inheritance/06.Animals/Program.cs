/*
Tomcat
Sivik 10 Male
Kitten
 10 haha
Frog
Gogo -20 
Dog
 10 Female
Beast!
 */

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string command;
            while ((command = Console.ReadLine()) != "Beast!")
            {
                string typeOfAnimal = command;

                string[] animalProperties = Console
                    .ReadLine()
                    .Split(" ");

                string animalName = animalProperties[0];
                int animalAge = int.Parse(animalProperties[1]);
                string animalGender = animalProperties[2];

                try
                {
                    switch (typeOfAnimal)
                    {
                        case "Dog":
                            Dog dog = new(animalName, animalAge, animalGender);
                            animals.Add(dog);
                            break;
                        case "Cat":
                            Cat cat = new(animalName, animalAge, animalGender);
                            animals.Add(cat);
                            break;
                        case "Frog":
                            Frog frog = new(animalName, animalAge, animalGender);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new(animalName, animalAge);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new(animalName, animalAge);
                            animals.Add(tomcat);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }             
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}