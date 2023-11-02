using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Tuple
{
    public class CustomTuple<T1, T2>
    {
        public T1 firstItem;
        public T2 secondItem;

        public CustomTuple(T1 firstItem, T2 secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public T1 FirstItem { get { return this.firstItem; } set {  this.firstItem = value; } }

        public T2 SecondItem { get { return this.secondItem; } set {  this.secondItem = value; } }
    }
}
