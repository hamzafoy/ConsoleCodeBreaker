﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCodeBreaker_Pegboard;

namespace ConsoleCodeBreaker_Player
{
    public class PlayerPegboard: Pegboard
    {
        public List<int[]> GuessLog = new();
        public override void PlacePegs()
        {
            Console.WriteLine("\nYou will need to 'place' your guesses one at a time.\n");
            for(int i = 0; i < Pegs.Length; i++)
            {
                string userInput = Console.ReadLine();
                userInput = (!String.IsNullOrEmpty(userInput)) ? userInput : "0";
                Int32.TryParse(userInput, out Pegs[i]);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(' ');
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            GuessLog.Add(new[] {Pegs[0], Pegs[1], Pegs[2], Pegs[3]});
            Console.WriteLine($"You submitted the following row: {Pegs[0]} {Pegs[1]} {Pegs[2]} {Pegs[3]}\n");
        }
    }
}