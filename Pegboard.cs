using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeBreaker_Pegboard
{
    public abstract class Pegboard
    {
        public int[] Pegs = new int[] { 0, 0, 0, 0};

        public abstract void PlacePegs();
    }
}
