using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class ListNode
    {
        public ListNode(int value)
        {
            this.Value = value;
        }

        public ListNode PreviousNode { get; set; }

        public ListNode NextNode { get; set; }

        public int Value { get; set; }
    }
}
