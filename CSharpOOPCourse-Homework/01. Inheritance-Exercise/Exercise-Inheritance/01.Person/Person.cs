using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private sbyte age;

        public Person(string name, sbyte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        { 
            get
            { 
                return this.name; 
            }
            set 
            {
                this.name = value; 
            } 
        }

        public virtual sbyte Age 
        { 
            get
            { 
                return this.age;
            } 
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }

                this.age = value; 
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}