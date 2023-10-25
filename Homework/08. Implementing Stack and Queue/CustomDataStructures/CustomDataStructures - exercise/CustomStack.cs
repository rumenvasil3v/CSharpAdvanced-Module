using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures_exercise
{
    public class CustomStack
    {
        const int InitialCapacity = 4;

        private int[] items;
        
        public CustomStack()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (this.Count == items.Length)
            {
                this.Resize();
            }

            this.items[this.Count++] = element;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            int element = this.items[this.Count - 1];
            this.Count--;

            return element;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            int element = this.items[this.Count - 1];

            return element;
        }

        public void ForEach(Action<int> action)
        {
            for (int n = this.Count - 1; n >= 0; n--)
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