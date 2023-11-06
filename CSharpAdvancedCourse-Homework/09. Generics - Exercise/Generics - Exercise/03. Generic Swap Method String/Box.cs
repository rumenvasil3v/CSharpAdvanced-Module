using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercises
{
    public class Box<T>
    {
        private const int IternalArraySize = 2;

        private int index;
        private T[] items;

        public Box()
        {
            this.items = new T[IternalArraySize];
        }

        public T[] Items { get { return this.items; }  set { this.items = value; } }

        public int Count { get; private set; }

        public void Add(T element)
        {
            if (this.index == this.items.Length)
            {
                Resize();
            }

            this.items[index++] = element;

            this.Count++;
        }

        private void Resize()
        {
            T[] copyArray = new T[this.Count * 2];

            for (int n = 0; n < this.items.Length; n++)
            {
                copyArray[n] = this.items[n];
            }

            this.items = copyArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int n = 0; n < index; n++)
            {
                sb.AppendLine($"{typeof(T)}: {this.items[n].ToString()}");
            }

            return sb.ToString();
        }
    }
}