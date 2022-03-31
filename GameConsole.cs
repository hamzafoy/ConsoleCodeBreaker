using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCodeBreaker_Player;
using ConsoleCodeBreaker_Opponent;
using ConsoleCodeBreaker_HistoryWriter;

namespace ConsoleCodeBreaker_GameConsole
{
    public class GameConsole
    {
        public static OpponentPegboard opponent = new();
        public static PlayerPegboard player = new();
        public static string Name = "Console Mastermind";
        public static string Description = "This game is based on the popular board game Mastermind.";
        public static string GameplayPrimer = @"The opponent is the computer which will decide on a row 
of 4 code-pegs which can be any number between 0 to 4. 
You will need to guess the code by guessing an 
assortment of 4 numbers between 0 to 5. You will get 
feedback that will inform you if you've guessed a 
correct number or position of guessed number. Use 
the provided feedback to logically discern the 
correct code that the opponent made.";

        public static void PlayGame()
        {
            StartUp();
            opponent.PlacePegs();
            HistoryWriter gameLog = HistoryWriter.GetInstance();
            string userInput = null;
            do
            {
                if (opponent.Feedback.Count > 0 && opponent.Feedback[opponent.Feedback.Count - 1][0] == "+" && opponent.Feedback[opponent.Feedback.Count - 1][1] == "+" && opponent.Feedback[opponent.Feedback.Count - 1][2] == "+" && opponent.Feedback[opponent.Feedback.Count - 1][3] == "+")
                {
                    Console.WriteLine($"You have successfully guessed the correct numbers and positions of said numbers! Good Job! \nIt took you {player.GuessLog.Count} guesses! Game closing. . .");
                    gameLog.WriteToFile(opponent.Pegs, player.GuessLog.Count, player.GuessLog, opponent.Feedback);
                    Console.WriteLine("Would you like to play again? Y or N");
                    //opponent.PlacePegs();
                    string confirmation = Console.ReadLine();
                    if (confirmation == "N" || confirmation == "n")
                    {
                        break;
                    }
                    else if (confirmation == "Y" || confirmation == null)
                    {
                        opponent.PlacePegs();
                        opponent.Feedback = new List<string[]>();
                        player.GuessLog = new List<int[]>();
                        Console.Clear();
                    }
                }
                if (player.GuessLog.Count == 10)
                {
                    Console.WriteLine("You have played 10 guesses and failed to crack the code. You Lose! \nGame closing. . .");
                    Console.WriteLine("Would you like to play again? Y or N");
                    //opponent.PlacePegs();
                    string confirmation = Console.ReadLine();
                    if (confirmation == "N" || confirmation == "n")
                    {
                        break;
                    }
                    else if (confirmation == "Y" || confirmation == null)
                    {
                        opponent.PlacePegs();
                        opponent.Feedback = new List<string[]>();
                        player.GuessLog = new List<int[]>();
                        Console.Clear();
                    }
                    //break;
                }
                Console.Write("Enter P to play, enter C to erase \nthe console & keep playing, enter V to view \nyour previous guesses, & enter Q to quit: ");
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
                    case "C":
                        for (int i = Console.CursorTop; i >= 8; i--)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.WriteLine(new String(' ', Console.WindowWidth));
                        }
                        //Console.SetCursorPosition(0, 8);
                        //Console.SetWindowPosition(0, 0);
                        Console.Clear();
                        break;
                    case "V":
                        int guessCount = 1;
                        for (int i = 0; i < player.GuessLog.Count; i++)
                        {
                            Console.WriteLine("\nThe following is a list of your guesses:");
                            Console.WriteLine($"Guess #{guessCount}: {player.GuessLog[i][0]} {player.GuessLog[i][1]} {player.GuessLog[i][2]} {player.GuessLog[i][3]}");
                            Console.WriteLine($"Feedback Returned: {opponent.Feedback[i][0]} {opponent.Feedback[i][1]} {opponent.Feedback[i][2]} {opponent.Feedback[i][3]}\n");
                            guessCount++;
                        }
                        break;
                    default:
                        Console.WriteLine("This input is not accepted. Try again and follow the prompt");
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
            Console.WriteLine($"{GameplayPrimer}\n");
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
            opponent.Feedback.Add(feedback);
            Console.WriteLine($"Your opponent responds with the following feedback: \n{opponent.Feedback[opponent.Feedback.Count - 1][0]} {opponent.Feedback[opponent.Feedback.Count - 1][1]} {opponent.Feedback[opponent.Feedback.Count - 1][2]} {opponent.Feedback[opponent.Feedback.Count - 1][3]}\n");
        }
    }
}
