using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomQueue
    {
        public QueueElement headElements;
        public QueueElement tailElements;

        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (headElements == null)
            {
                headElements = tailElements = new QueueElement(element);
            }
            else if (headElements != null)
            {
                var current = new QueueElement(element);
                current.PreviousElements = headElements;
                headElements.NextElements = current;
                headElements = current;
            }

            this.Count++;
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int element = tailElements.Value;
            tailElements = tailElements.NextElements;
            if (tailElements == null)
            {
                headElements = null;
            }
            else
            {
                tailElements.PreviousElements = null;
            }

            this.Count--;
            return element;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int element = tailElements.Value;

            return element;
        }

        public void Clear()
        {
            headElements = null;
            tailElements = null;
        }

        public void ForEach(Action<int> action)
        {
            var current = tailElements;
            while (current != null)
            {
                action(current.Value);
                current = current.NextElements;
            }
        }
    }
}