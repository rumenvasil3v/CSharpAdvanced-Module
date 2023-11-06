using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Custom_Linked_List
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                head = new ListNode<T>(element);
                tail = head;
            }
            else
            {
                var newElement = new ListNode<T>(element);
                newElement.NextElement = head;
                head.PreviousElement = newElement;
                head = newElement;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            if (Count == 0)
            {
                head = new ListNode<T>(element);
                tail = head;
            }
            else
            {
                var newElement = new ListNode<T>(element);
                newElement.PreviousElement = tail;
                tail.NextElement = newElement;
                tail = newElement;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            T element = head.Value;
            head = head.NextElement;
            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousElement = null;
            }

            Count--;
            return element;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            T element = tail.Value;
            tail = tail.PreviousElement;
            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextElement = null;
            }

            Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            int index = 0;

            var current = head;
            while (current != null)
            {
                array[index++] = current.Value;
                current = current.NextElement;
            }

            return array;
        }

        public void ForEach(Action<T> action)
        {
            T[] array = ToArray();

            foreach (var element in array)
            {
                action(element);
            }
        }
    }
}