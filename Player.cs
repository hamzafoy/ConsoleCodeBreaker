using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeBreaker_Player
{
    public class Player
    {
        public static int[] GuessSequence = new int[] { 0, 0, 0, 0 };
        public static void PlacePegs()
        {
            Console.WriteLine("You will need to 'place' your guesses one at a time");
            for(int i = 0; i < GuessSequence.Length; i++)
            {
                Int32.TryParse(Console.ReadLine(), out GuessSequence[i]);
            }
            Console.WriteLine($"{GuessSequence[0]} {GuessSequence[1]} {GuessSequence[2]} {GuessSequence[3]}");
        }
    }
}
