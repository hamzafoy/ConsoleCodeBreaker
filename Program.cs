/// <remarks>
/// 
/// This application can be played in the console and is based on the game Mastermind.
/// The Console App will have the computer render a code that is 4 colors randomly selected
/// from Red, Black, White, Green, Blue, or Yellow. The user has to try to guess the code and
/// has 10 tries to crack the code. The computer will help the user understand how their guess
/// lines up to the correct code by giving either White or Red Marks: Red Marks means that there
/// is a correct color in the correct position and White Marks means that there is a correct color
/// in the incorrect position.
/// 
/// </remarks>

using System;
using System.Collections.Generic;
using ConsoleCodeBreaker_Opponent;
using ConsoleCodeBreaker_Player;
using ConsoleCodeBreaker_GameConsole;

namespace ConsoleCodeBreaker
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "Console Mastermind - A Code Louisville Capstone";
            //GameConsole.opponent.PlacePegs();
            GameConsole.PlayGame();
        }
    }
}