using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures_exercise
{
    public class CustomList
    {
        private const int Capacity = 2;

        private int[] items;
        private int indexer;

        public CustomList()
        {
            this.items = new int[Capacity];
        }

        public int[] Items 
        { 
            get
            {
                int[] tempArray = new int[this.Count];
                for (int n = 0; n < this.Count; n++)
                {
                    tempArray[n] = this.items[n];
                }

                return tempArray;
            } 
        }

        public int this[int index] //or public T this[int index]
        {
            get 
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index was out of range.");
                }

                return this.items[index]; 
            }
            set 
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index was out of range.");
                }

                this.items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(int element)
        {
            if (this.Count == items.Length)
            {
                Resize();
            }

            this.items[this.indexer++] = element;
            this.Count++;
        }

        public void Insert(int index, int element)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Index was out of range.");
            }

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
            this.indexer++;
        }

        public int RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the list!");               
            }

            int element = this.items[index];
            this.items[index] = default;
            this.Shift(index);

            this.indexer--;
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        public bool Contains(int element)
        {
            bool doesItHaveSuchElement = false;
            foreach (var item in this.items)
            {
                if (item == element)
                {
                    doesItHaveSuchElement = true;
                    break;
                }
            }

            return doesItHaveSuchElement;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= this.Count
                || secondIndex < 0 || secondIndex >= this.Count)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the list!");
            }

            int firstElement = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = firstElement;
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
            int[] resizedArray = new int[Capacity * this.items.Length];
            Array.Copy(this.items, resizedArray, this.items.Length);

            this.items = resizedArray;
        }

        private void Shrink()
        {
            int[] shrinkedArray = new int[this.items.Length / Capacity];
            Array.Copy(this.items, shrinkedArray, this.items.Length / Capacity);

            this.items = shrinkedArray;
        }

        private void Shift(int index)
        {
            for (int n = index; n < this.Count - 1; n++)
            {
                this.items[n] = this.items[n + 1];
            }
        }

        private void ShiftToRight(int index)

        {
            for (int n = this.Count; n > index; n--)
            {
                this.items[n] = this.items[n - 1];
            }
        }
    }
}