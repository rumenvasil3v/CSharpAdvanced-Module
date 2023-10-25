using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures_exercise
{
    public class CustomQueue
    {
        const int InitialCapacity = 4;
        const int FirstElementIndex = 0;

        private int[] items;

        public CustomQueue()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count++] = element;
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int element = this.items[FirstElementIndex];
            var newArray = new int[this.items.Length];
            for (int n = 1; n < this.Count; n++)
            {
                newArray[n - 1] = this.items[n];
            }

            this.items = newArray;

            this.Count--;
            return element;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int element = this.items[FirstElementIndex];

            return element;
        }

        public void Clear()
        {
            this.items = new int[InitialCapacity];
            this.Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int n = 0; n < this.Count; n++)
            {
                action(this.items[n]);
            }
        }

        private void Resize()
        {
            int[] resizedArray = new int[InitialCapacity * this.items.Length];
            Array.Copy(this.items, resizedArray, this.items.Length);

            this.items = resizedArray;
        }
    }
}