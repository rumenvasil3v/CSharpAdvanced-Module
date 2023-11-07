using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        public DateTime lunch;

        public Employee() : base("George", 16)
        {

        }

        public DateTime Lunch { get {  return this.lunch; } set { this.lunch = value; } }
    }
}