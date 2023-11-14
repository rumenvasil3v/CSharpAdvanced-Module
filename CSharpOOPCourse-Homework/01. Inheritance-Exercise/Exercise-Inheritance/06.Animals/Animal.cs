using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        { 
            get 
            { 
                return this.name;
            } 
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        { 
            get
            { 
                return this.age;
            } 
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value; 
            } 
        }

        public string Gender
        {
            get 
            { 
                return this.gender;
            } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(this.ProduceSound());

            return sb.ToString();
        }

        public abstract string ProduceSound();
    }
}