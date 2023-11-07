/*
Pizza SoftUni
Dough White Chewy 100
Topping Sauce 100
Topping Cheese 50
Topping Cheese 40
Topping Meat 10
Topping Sauce 10
Topping Cheese 30
Topping Cheese 40
Topping Meat 20
Topping Sauce 30
Topping Cheese 25
Topping Cheese 40
Topping Meat 40
END
 */
using PizzaCalories.Models;
using System.Runtime.CompilerServices;

try
{
    string[] pizzaArguments = Console.ReadLine().Split(" ");
    string pizzaName = pizzaArguments[1];

    Pizza pizza = new(pizzaName);

    string[] doughArguments = Console.ReadLine().Split(" ");
    string flourType = doughArguments[1];
    string bakingTechnique = doughArguments[2];
    double weightDough = double.Parse(doughArguments[3]);

    Dough dough = new(flourType, bakingTechnique, weightDough);
    pizza.Dough = dough;

    string command;
    while ((command = Console.ReadLine()) != "END")
    {
        string[] commandArguments = command.Split(" ");

        if (commandArguments[0] == "Topping")
        {
            string toppingType = commandArguments[1];
            double toppingTypeWeight = double.Parse(commandArguments[2]);

            Topping topping = new(toppingType, toppingTypeWeight);

            pizza.AddTopping(topping);
        }
    }

    Console.WriteLine(pizza.ToString());
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}