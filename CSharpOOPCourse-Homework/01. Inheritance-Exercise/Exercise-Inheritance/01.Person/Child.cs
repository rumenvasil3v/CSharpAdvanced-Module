using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, sbyte age) : base(name, age)
        {
        }

        public override sbyte Age 
        { 
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Invalid data!");
                }

                base.Age = value; 
            }
        }
    }
}
