using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.EmptyNameException);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get => this.products.AsReadOnly();
        }

        public void AddProduct(Product product)
        {
            if (product is null)
            {
                throw new ArgumentException("Object is not set to reference");
            }

            this.Money -= product.Price;
            this.products.Add(product);

            Console.WriteLine($"{this.Name} bought {product.Name}");
        }

        public override string ToString()
        {
            string products = this.products.Count == 0 ? "Nothing bought" : string.Join(", ", this.products);

            return $"{this.Name} - {products}";
        }
    }
}