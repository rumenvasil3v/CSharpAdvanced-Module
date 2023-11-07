using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchies
{
    public class SinglePlayerGame : Game
    {
        private int price;

        public int Price { get { return this.price; } set {  this.price = value; } }
    }
}
