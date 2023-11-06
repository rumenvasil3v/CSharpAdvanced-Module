using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T> where T : IEquatable<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T Left { get { return this.left; } set { this.left = value; } }

        public T Right { get { return this.right; } set { this.right = value; } }

        public bool AreEqual()
        {
            if (this.left.Equals(this.right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
