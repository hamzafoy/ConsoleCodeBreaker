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
        public override void PlacePegs()
        {
            Console.WriteLine("You will need to 'place' your guesses\none at a time");
            for(int i = 0; i < Pegs.Length; i++)
            {
                string userInput = Console.ReadLine();
                userInput = (!String.IsNullOrEmpty(userInput)) ? userInput : "0";
                Int32.TryParse(userInput, out Pegs[i]);
            }
            Console.WriteLine($"{Pegs[0]} {Pegs[1]} {Pegs[2]} {Pegs[3]}");
        }
    }
}