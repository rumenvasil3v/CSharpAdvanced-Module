/*
Peter=11;George=4
=10;Milk=2;
Peter Bread
George Milk
George Milk
Peter Milk
END

 =-3
Peppers=1;Tomatoes=2;Cheese=3
John Peppers
John Tomatoes
John Cheese
END

 */

using ShoppingSpree;
using ShoppingSpree.Models;
using System;
using System.Globalization;

string[] peopleArguments = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, Person> people = new Dictionary<string, Person>();

try
{

    foreach (string person in peopleArguments)
    {
        string[] currentPersonArguments = person.Split('=', StringSplitOptions.RemoveEmptyEntries);

        string personName = currentPersonArguments[0];
        decimal personBudget = decimal.Parse(currentPersonArguments[1]);

        Person currentPerson = new(personName, personBudget);

        if (!people.ContainsKey(personName))
        {
            people.Add(personName, currentPerson);
        }
    }

    string[] productArguments = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

    Dictionary<string, Product> products = new Dictionary<string, Product>();

    foreach (string product in productArguments)
    {
        string[] currentProductArguments = product.Split('=', StringSplitOptions.RemoveEmptyEntries);

        string productName = currentProductArguments[0];
        decimal productPrice = decimal.Parse(currentProductArguments[1]);

        Product currentProduct = new(productName, productPrice);

        if (!products.ContainsKey(productName))
        {
            products.Add(productName, currentProduct);
        }
    }

    string command;
    while ((command = Console.ReadLine()) != "END")
    {
        string[] commandArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string currentPersonName = commandArguments[0];
        string currentProductName = commandArguments[1];

        decimal currentProductPrice = products[currentProductName].Price;

        if (people[currentPersonName].Money - currentProductPrice < 0)
        {
            Console.WriteLine($"{currentPersonName} can't afford {currentProductName}");
        }
        else
        {
            people[currentPersonName].AddProduct(products[currentProductName]);
        }
    }

    foreach (var person in people)
    {
        Console.WriteLine(person.Value.ToString());
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}