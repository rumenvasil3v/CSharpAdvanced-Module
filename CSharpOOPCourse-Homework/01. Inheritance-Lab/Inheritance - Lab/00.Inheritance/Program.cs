namespace Inheritance
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Student student = new Student();

            employee.Name = "Dimitar";
            employee.Age = 50;
            student.Name = "Pesho";
            student.Age = 30;

            Console.WriteLine(employee.Name + " - " + employee.Age);
            Console.WriteLine(student.Name + " - " + student.Age);

            student.PrintStudent();
        }
    }
}