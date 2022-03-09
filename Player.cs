﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ConsoleCodeBreaker_Pegboard;

namespace ConsoleCodeBreaker_Player
{
    public class PlayerPegboard: Pegboard
    {
        public List<int[]> GuessLog = new();
        public override void PlacePegs()
        {
            Regex guessFormat = new Regex(@"[0-4] [0-4] [0-4] [0-4]");
            //Console.WriteLine(guessFormat.IsMatch("0 1 2 3"));
            Console.WriteLine("You must format your code guess like this: # # # #");
            Console.WriteLine("An example being: 0 2 1 0");
            string userCode = Console.ReadLine();
            string[] userCodeArray = userCode.Split(' ');
            if (guessFormat.IsMatch(userCode))
            {
                Console.WriteLine("Guess accepted");
                for (int i = 0; i < Pegs.Length; i++)
                {
                    Int32.TryParse(userCodeArray[i], out Pegs[i]);
                }
                GuessLog.Add(new[] { Pegs[0], Pegs[1], Pegs[2], Pegs[3] });
                Console.WriteLine($"You submitted the following row: {Pegs[0]} {Pegs[1]} {Pegs[2]} {Pegs[3]}\n");
            }
            else
            {
                Console.WriteLine("Your input is unacceptable, try again!");
            }
            //Console.WriteLine("\nYou will need to 'place' your guesses one at a time.\n");
            //for(int i = 0; i < Pegs.Length; i++)
            //{
            //    string userInput = Console.ReadLine();
            //    userInput = (!String.IsNullOrEmpty(userInput)) ? userInput : "0";
            //    Int32.TryParse(userInput, out Pegs[i]);
            //    Console.SetCursorPosition(0, Console.CursorTop - 1);
            //    Console.Write(' ');
            //    Console.SetCursorPosition(0, Console.CursorTop);
            //}
        }
    }
}