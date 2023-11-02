using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Generic_Box_of_Integer___exercise
{
    public class Box<T>
    {
        private T element;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get {return this.element; } set { this.element = value; } }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Value}";
        }
    }
}
