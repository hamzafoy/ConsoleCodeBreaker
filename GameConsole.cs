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
        public static List<int[]> ConsoleFeedback = new();
        public static OpponentPegboard opponent = new();
        public static PlayerPegboard player = new();
        public static string Name = "Console Mastermind";
        public static string Description = "This game is based on the popular board\ngame Mastermind.";

        public static void StartUp()
        {
            Console.WriteLine($"|~~~~~~~~| :: {Name} :: |~~~~~~~~|");
            Console.WriteLine($"{Description}\n");
        }

        public static void CodeCheck(PlayerPegboard playersPegs, OpponentPegboard opponentsPegs)
        {
            Console.WriteLine("|********| :: Feedback :: |********|");
            string[] feedback = { "_", "_", "_", "_" };
            for (int i = 0; i < playersPegs.Pegs.Length; i++)
            {
                switch (playersPegs.Pegs[i])
                {
                    case 0:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        } else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                    case 1:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        }
                        else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                    case 2:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        }
                        else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                    case 3:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        }
                        else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                    case 4:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        }
                        else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                    case 5:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                        {
                            feedback[i] = "+";
                        }
                        else
                        {
                            feedback[i] = (Array.IndexOf(opponentsPegs.Pegs, playersPegs.Pegs[i]) == -1) ? "_" : "-";
                        }
                        break;
                }
            }
            Console.WriteLine($"{feedback[0]} {feedback[1]} {feedback[2]} {feedback[3]}");
        }
    }
}
