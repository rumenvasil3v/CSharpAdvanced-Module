using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Generic_Swap_Method_Integer___Exercise
{
    public class Box<T>
    {
        private T element;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get { return this.element; } set { this.element = value; } }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Value}";
        }
    }
}
