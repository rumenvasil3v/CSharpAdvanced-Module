using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class StackElement
    {
        public StackElement(int value)
        {
            this.Value = value;
        }

        public StackElement NextElement { get; set; }

        public int Value { get; set; }
    }
}
