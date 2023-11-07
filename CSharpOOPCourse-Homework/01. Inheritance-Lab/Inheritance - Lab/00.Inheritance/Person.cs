using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        private string name;
        public int age;
        protected string nationality;
        internal string adress;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string nationality)
        {
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
        }

        public string Name { get { return this.name; } set { this.name = value; } }

        public int Age { get { return this.age; } set { this.age = value; } }

        public string Nationality { get { return this.nationality; } set { this.nationality = value; } }
    }
}