using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class QueueElement
    {
        public QueueElement(int value) 
        {
            this.Value = value;
        }

        public int Value { get; set; }  

        public QueueElement NextElements { get; set; }

        public QueueElement PreviousElements { get; set; }
    }
}
