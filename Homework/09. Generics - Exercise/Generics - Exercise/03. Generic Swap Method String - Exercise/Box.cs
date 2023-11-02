using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Generic_Swap_Method_String___Exercise
{
    public class Box<T>
    {
        private T element;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get {return this.element; } set { this.element = value; } }

        static public void SwapElements(List<Box<T>> list, int firstIndex, int secondIndex)
        {
            Box<T> firstElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstElement;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Value}";
        }
    }
}
