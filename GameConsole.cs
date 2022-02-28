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
            int[] numOfColors = new int[6];
            for (int i = 0; i < numOfColors.Length; i++)
            {
                numOfColors[i] = Array.FindAll(opponentsPegs.Pegs, element => element == i).Length;
                Console.WriteLine(numOfColors[i]);
            }
            for (int i = 0; i < playersPegs.Pegs.Length; i++)
            {
                switch (playersPegs.Pegs[i])
                {
                    case 0:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[0] > 0)
                        {
                            numOfColors[0]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[0] > 0)
                        {
                            numOfColors[0]--;
                            feedback[i] = "x";
                        } else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 1:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[1] > 0)
                        {
                            numOfColors[1]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[1] > 0)
                        {
                            numOfColors[1]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 2:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[2] > 0)
                        {
                            numOfColors[2]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[2] > 0)
                        {
                            numOfColors[2]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 3:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[3] > 0)
                        {
                            numOfColors[3]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[3] > 0)
                        {
                            numOfColors[3]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 4:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[4] > 0)
                        {
                            numOfColors[4]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[4] > 0)
                        {
                            numOfColors[4]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 5:
                        if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i] && numOfColors[5] > 0)
                        {
                            numOfColors[5]--;
                            feedback[i] = "+";
                        }
                        else if (numOfColors[5] > 0)
                        {
                            numOfColors[5]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                }
            }
            Console.WriteLine($"{feedback[0]} {feedback[1]} {feedback[2]} {feedback[3]}");
        }
    }
}
