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
                var newElement = new QueueElement(element);
                newElement.PreviousElements = tailElements;
                tailElements.NextElements = newElement;
                tailElements = newElement;

                headElements.NextElements = tailElements.PreviousElements;
            }

            this.Count++;
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int element = headElements.Value;
            headElements = headElements.NextElements;
            if (headElements == null)
            {
                tailElements = null;
            }
            else
            {
                headElements.PreviousElements = null;
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

            int element = headElements.Value;

            return element;
        }

        public void Clear()
        {
            headElements = null;
            tailElements = null;
        }

        public void ForEach(Action<int> action)
        {
            var current = headElements;
            while (current != null)
            {
                action(current.Value);
                current = current.NextElements;
            }
        }
    }
}