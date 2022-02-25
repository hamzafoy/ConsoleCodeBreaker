using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCodeBreaker_Pegboard;

namespace ConsoleCodeBreaker_Opponent
{
    public class OpponentPegboard : Pegboard
    {
        public override void PlacePegs()
        {
            Random pegGenerator = new Random();
            for(int i = 0; i < Pegs.Length; i++)
            {
                Pegs[i] = pegGenerator.Next(5);
                Console.Write("{0} ",Pegs[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
