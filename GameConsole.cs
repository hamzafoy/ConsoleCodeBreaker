using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCodeBreaker_Player;
using ConsoleCodeBreaker_Opponent;

namespace ConsoleCodeBreaker_GameConsole
{
    public class GameConsole
    {
        public static OpponentPegboard opponent = new();
        public static PlayerPegboard player = new();
        public static string Name = "Console Mastermind";
        public static string Description = "This game is based on the popular board game\nMastermind.";

        public static void StartUp()
        {
            Console.WriteLine($"~~~~~~| {Name} |~~~~~~");
            Console.WriteLine($"{Description}\n");
        }
    }
}
