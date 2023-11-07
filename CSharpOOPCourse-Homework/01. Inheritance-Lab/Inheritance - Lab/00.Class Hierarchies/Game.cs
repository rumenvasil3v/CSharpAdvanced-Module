using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchies
{
    public class Game
    {
        private const int TrialDurationInMonths = 3;
        private string genre;
        private int price;

        public int Price { get { return this.price; } set { this.price = value; } }

        public string Genre {  get { return this.genre; } set { this.genre = value; } }
    }
}
