using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchies
{
    public class Fortnite : MultiPlayerGame
    {
        private string modes;

        public string Modes { get { return this.modes} set { this.modes = value; } }
    }
}
