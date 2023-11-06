using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomStack
    {
        public StackElement elements;

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (elements == null)
            {
                elements = new StackElement(element);
            }
            else if (this.elements != null)
            {
                var newElement = new StackElement(element);
                newElement.NextElement = elements;
                elements = newElement;
            }

            this.Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            int element = elements.Value;
            elements = elements.NextElement;

            this.Count--;
            return element;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            int element = elements.Value;

            return element;
        }

        public void ForEach(Action<int> action)
        {
            var currentElement = elements;
            while (currentElement != null)
            {
                action(currentElement.Value);
                currentElement = currentElement.NextElement;
            }
        }
    }
}