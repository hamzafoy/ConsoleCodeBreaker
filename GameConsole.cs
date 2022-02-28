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
            int[] numOfOpponentColors = new int[6];
            int[] numOfPlayerColors = new int[6];
            for (int i = 0; i < numOfPlayerColors.Length; i++)
            {
                numOfOpponentColors[i] = Array.FindAll(opponentsPegs.Pegs, element => element == i).Length;
                numOfPlayerColors[i] = Array.FindAll(playersPegs.Pegs, element => element == i).Length;
            }
            Console.WriteLine($"Player has {numOfPlayerColors[0]} 0s, {numOfPlayerColors[1]} 1s, {numOfPlayerColors[2]} 2s, {numOfPlayerColors[3]} 3s, {numOfPlayerColors[4]} 4s, {numOfPlayerColors[5]} 5s");
            Console.WriteLine($"Opponent has {numOfOpponentColors[0]} 0s, {numOfOpponentColors[1]} 1s, {numOfOpponentColors[2]} 2s, {numOfOpponentColors[3]} 3s, {numOfOpponentColors[4]} 4s, {numOfOpponentColors[5]} 5s");
            for (int i = 0; i < playersPegs.Pegs.Length; i++)
            {
                switch (playersPegs.Pegs[i])
                {
                    case 0:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 0))
                        {
                            
                            if(playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            } else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            } else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[0] > 0)
                        {
                            numOfOpponentColors[0]--;
                            feedback[i] = "x";
                        } else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 1:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 1))
                        {
                            numOfOpponentColors[1]--;
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            }
                            else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[1] > 0)
                        {
                            numOfOpponentColors[1]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 2:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 2) && numOfOpponentColors[2] >= 0)
                        {
                            numOfOpponentColors[2]--;
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            }
                            else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[2] > 0)
                        {
                            numOfOpponentColors[2]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 3:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 3) && numOfOpponentColors[3] >= 0)
                        {
                            numOfOpponentColors[3]--;
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            }
                            else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[3] > 0)
                        {
                            numOfOpponentColors[3]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 4:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 4) && numOfOpponentColors[4] >= 0)
                        {
                            numOfOpponentColors[4]--;
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            }
                            else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[4] > 0)
                        {
                            numOfOpponentColors[4]--;
                            feedback[i] = "x";
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 5:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 5) && numOfOpponentColors[5] >= 0)
                        {
                            numOfOpponentColors[5]--;
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (!Array.Exists(opponentsPegs.Pegs, element => element == playersPegs.Pegs[i]))
                            {
                                feedback[i] = "_";
                            }
                            else
                            {
                                feedback[i] = "x";
                            }
                        }
                        else if (numOfOpponentColors[5] > 0)
                        {
                            numOfOpponentColors[5]--;
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
