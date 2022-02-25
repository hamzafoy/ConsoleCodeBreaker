using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeBreaker_Opponent
{
    public class Opponent
    {
        public static int[] CodePegs = new int[] { 0, 0, 0, 0 };

        public static void PlacePegs()
        {
            Random pegGenerator = new Random();
            for(int i = 0; i < CodePegs.Length; i++)
            {
                CodePegs[i] = pegGenerator.Next(5);
                Console.Write("{0} ",CodePegs[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
