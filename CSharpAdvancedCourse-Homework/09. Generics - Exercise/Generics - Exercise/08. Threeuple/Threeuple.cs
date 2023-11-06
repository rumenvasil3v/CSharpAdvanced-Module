using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Threeuple
{
    public class Threeuple<T1, T2, T3>
    {
        public T1 firstItem;
        public T2 secondItem;
        private T3 thirdItem;

        public Threeuple(T1 firstItem, T2 secondItem, T3 thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public T1 FirstItem { get { return this.firstItem; } set { this.firstItem = value; } }

        public T2 SecondItem { get { return this.secondItem; } set { this.secondItem = value; } }

        public T3 ThirdItem { get { return this.thirdItem; } 
            set 
            {

                this.thirdItem = value; 
            }
        }
    }
}
