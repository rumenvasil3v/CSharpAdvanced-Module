using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] shopArguments = command.Split(", ");

                string currentShop = shopArguments[0];
                string productShop = shopArguments[1];
                double productPrice = double.Parse(shopArguments[2]);

                Shop shop = new Shop(currentShop, productShop, productPrice);

                shop.AddingProducts(shops);
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }

    public class Shop
    {

        public Shop(string name, string product, double productPrice)
        {
            this.Name = name;
            this.Product = product;
            this.ProductPrice = productPrice;
        }

        public string Name { get; set; }

        public string Product { get; set; }

        public double ProductPrice { get; set; }

        public void AddingProducts(Dictionary<string, Dictionary<string, double>> shops)
        {
            if (!shops.ContainsKey(this.Name))
            {
                shops.Add(this.Name, new Dictionary<string, double>() { { this.Product, this.ProductPrice } });
                return;
            }

            shops[this.Name].Add(this.Product, this.ProductPrice);
        }
    }
}