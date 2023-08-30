using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> shops = new Dictionary<string, Dictionary<string, decimal>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string input = Console.ReadLine();
                string[] shopArguments = input.Split(", ");

                string currentShop = shopArguments[0];
                string productShop = shopArguments[1];
                decimal productPrice = decimal.Parse(shopArguments[2]);

                Shop shop = new Shop(currentShop, productShop, productPrice);

                if ()
            }
        }
    }

    public class Shop
    {

        public Shop(string name, string product, decimal productPrice)
        {
            this.Name = name;
            this.Product = product;
            this.ProductPrice = productPrice;
        }

        public string Name { get; set; }

        public string Product { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
