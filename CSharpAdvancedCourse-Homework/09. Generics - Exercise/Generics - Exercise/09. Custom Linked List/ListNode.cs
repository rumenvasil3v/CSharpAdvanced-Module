using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Custom_Linked_List
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }

        public ListNode<T> PreviousElement { get; set; }

        public ListNode<T> NextElement { get; set; }

        public T Value { get; set; }
    }
}
