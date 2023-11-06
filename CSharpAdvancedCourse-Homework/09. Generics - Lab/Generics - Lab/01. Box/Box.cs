using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private const int InitialSize = 2;
        private T[] items = new T[InitialSize];

        private int index = 0;
        private int count = 0;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (index == InitialSize)
            {
                Resize();
            }

            items[index++] = element;

            count++;
        }

        public T Remove()
        {
            T element = items[index - 1];
            index--;

            count--;
            return element;
        }

        private void Resize()
        {
            T[] copyArray = new T[this.Count * 2];

            for (int n = 0; n < items.Length; n++)
            {
                copyArray[n] = items[n];
            }

            items = copyArray;
        }
    }
}
