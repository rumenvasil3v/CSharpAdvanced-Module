using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private int addRange;
        private string element;

        public StackOfStrings(string element)
        {
            this.element = element;
            this.addRange = 10;
        }

        public bool IsEmpty()
        {
            bool isEmpty = this.Count == 0;

            return isEmpty;
        }

        public void AddRange() 
        {
            for (int n = 0; n < this.addRange; n++)
            {
                this.Push(element);
            }
        }
    }
}