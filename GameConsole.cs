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
        //public static List<string[]> ConsoleFeedback = new();
        public static OpponentPegboard opponent = new();
        public static PlayerPegboard player = new();
        public static string Name = "Console Mastermind";
        public static string Description = "This game is based on the popular board game Mastermind.";

        public static void PlayGame()
        {
            //Console.WriteLine("Game starting up now. . .");
            StartUp();
            string userInput = null;
            do
            {
                Console.Write("Enter P to play, enter Q to quit: ");
                userInput = Console.ReadLine().ToUpper();
                switch(userInput)
                {
                    case "Q":
                        Console.WriteLine("You have opted to exit the program. . . Goodbye!");
                        break;
                    case "P":
                        player.PlacePegs();
                        CodeCheck(player, opponent);
                        break;
                }
                if (userInput == "Q" || userInput == "q")
                {
                    break;
                }
            } while (userInput != "Q" || userInput != "q");
        }
        public static void StartUp()
        {
            Console.WriteLine($"|******************************************************|");
            Console.WriteLine($"|*************|                          |*************|");
            Console.WriteLine($"|*************| :: Console Mastermind :: |*************|");
            Console.WriteLine($"|*************|                          |*************|");
            Console.WriteLine($"|******************************************************|\n");
            Console.WriteLine($"{Description}\n");
        }

        public static void CodeCheck(PlayerPegboard playersPegs, OpponentPegboard opponentsPegs)
        {
            Console.WriteLine($"|******************************************************|");
            Console.WriteLine($"|***************|                      |***************|");
            Console.WriteLine($"|***************|    :: Feedback ::    |***************|");
            Console.WriteLine($"|***************|                      |***************|");
            Console.WriteLine($"|******************************************************|\n");
            Console.WriteLine("+ indicates right color/right position\nx indicates right color/wrong position\n_ indicates wrong color/wrong position\n");
            string[] feedback = { "_", "_", "_", "_" };
            int[] numOfOpponentColors = new int[6];
            int[] numOfPlayerColors = new int[6];
            for (int i = 0; i < numOfPlayerColors.Length; i++)
            {
                numOfOpponentColors[i] = Array.FindAll(opponentsPegs.Pegs, element => element == i).Length;
                numOfPlayerColors[i] = Array.FindAll(playersPegs.Pegs, element => element == i).Length;
            }
            //Console.WriteLine($"Player has {numOfPlayerColors[0]} 0s, {numOfPlayerColors[1]} 1s, {numOfPlayerColors[2]} 2s, {numOfPlayerColors[3]} 3s, {numOfPlayerColors[4]} 4s, {numOfPlayerColors[5]} 5s");
            //Console.WriteLine($"Opponent has {numOfOpponentColors[0]} 0s, {numOfOpponentColors[1]} 1s, {numOfOpponentColors[2]} 2s, {numOfOpponentColors[3]} 3s, {numOfOpponentColors[4]} 4s, {numOfOpponentColors[5]} 5s");
            for (int i = 0; i < playersPegs.Pegs.Length; i++)
            {
                switch (playersPegs.Pegs[i])
                {
                    case 0:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 0))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[0] > numOfOpponentColors[0] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[0] <= numOfOpponentColors[0])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 1:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 1))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[1] > numOfOpponentColors[1] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[1] <= numOfOpponentColors[1])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 2:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 2))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[2] > numOfOpponentColors[2] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[2] <= numOfOpponentColors[2])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 3:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 3))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[3] > numOfOpponentColors[3] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[3] <= numOfOpponentColors[3])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 4:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 4))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[4] > numOfOpponentColors[4] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[4] <= numOfOpponentColors[4])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                    case 5:
                        if (Array.Exists(opponentsPegs.Pegs, element => element == 5))
                        {
                            if (playersPegs.Pegs[i] == opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "+";
                            }
                            else if (numOfPlayerColors[5] > numOfOpponentColors[5] && playersPegs.Pegs[i] != opponentsPegs.Pegs[i])
                            {
                                feedback[i] = "_";
                            }
                            else if (numOfPlayerColors[5] <= numOfOpponentColors[5])
                            {
                                feedback[i] = "x";
                            }
                        }
                        else
                        {
                            feedback[i] = "_";
                        }
                        break;
                }
            }
            //Console.WriteLine($"Your opponent responds with the following feedback: \n{feedback[0]} {feedback[1]} {feedback[2]} {feedback[3]}\n");
            opponent.Feedback.Add(feedback);
            foreach (string[] elementArray in opponent.Feedback)
            {
                Console.WriteLine($"Your opponent responds with the following feedback: \n{elementArray[0]} {elementArray[1]} {elementArray[2]} {elementArray[3]}\n");
            }
        }
    }
}
