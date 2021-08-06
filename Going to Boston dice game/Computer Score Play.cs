using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Game;
namespace Going_to_Boston_dice_game
{
    public class Computer_Score_Play
    {
        public static void Computer_Score()
        {
            var game = new Game_Play();

            Console.WriteLine("Enter name of Player 1:");
            game.Player1 = Console.ReadLine();

            while (game.Playing2)
            {
                while (game.Round2)
                {
                    while (game.RoundNum2 < 9)

                    {
                        // Starts Round 1 of score Play 
                        game.RoundNum2++;
                        // Message for Player 1
                        Console.WriteLine(game.Player1 + " press enter to roll three dice");
                        Console.ReadLine();

                        // Display three random numbers from 1 to 6 for Player 1

                        Random Player1numbers1 = new Random();
                        for (int numbercount = 0; numbercount < 3; numbercount++)
                        {
                            game.Player1Dice = Player1numbers1.Next(1, 7);

                            /// Finds maxiumn number out of the three random numbers

                            if (game.Player1Dice > game.Player1score)
                            {
                                game.Player1score = game.Player1Dice;

                            }

                            Console.WriteLine(game.Player1Dice);


                        }

                        /// Dispalys maxiumn number (Player 1's score) from three random numbers

                        Console.WriteLine(game.Player1 + " your score is " + game.Player1score);


                        // Message for Player 1
                        Console.WriteLine(game.Player1 + " press enter to roll two dice");
                        Console.ReadLine();

                        /// Display two random numbers for Player 1

                        Random Player1numbers2 = new Random();
                        for (int numbercount = 0; numbercount < 2; numbercount++)
                        {
                            game.Player1Dice = Player1numbers2.Next(1, 7);


                            if (game.Player1Dice > game.Player1score2)
                            {
                                game.Player1score2 = game.Player1Dice;
                            }


                            Console.WriteLine(game.Player1Dice);

                        }

                        /// Dispalys maxiumn number (Player 1's score)sz from three random numbers
                        Console.WriteLine(game.Player1 + " your score is:" + game.Player1score2);

                        /// Display one random number for Player 1

                        Console.WriteLine(game.Player1 + " press enter to roll a die:");
                        Console.ReadLine();

                        // Finds maxiumn numbers from random numbers
                        Random Player1numbers3 = new Random();
                        for (int numbercount = 0; numbercount < 1; numbercount++)
                        {
                            game.Player1Dice = Player1numbers3.Next(1, 7);

                            if (game.Player1Dice > game.Player1score3)
                            {
                                game.Player1score3 = game.Player1Dice;
                            }

                            Console.WriteLine(game.Player1Dice);

                            /// Dispalys maxiumn number (Player 1's score)
                            Console.WriteLine(game.Player1 + " your score is:" + game.Player1Dice);

                            Console.WriteLine("\n");
                        }

                        game.Player1Totalscore = (game.Player1score + game.Player1score2 + game.Player1Dice);
                        Console.WriteLine(game.Player1 + " your total score is:" + game.Player1Totalscore);
                        Console.WriteLine("Computer's turn, please wait");
                        Thread.Sleep(4000);

                        /// Display three random numbers for Player 2                   
                        Console.WriteLine("Computer rolls three dice");

                        for (int numbercount = 0; numbercount < 3; numbercount++)
                        {

                            Random Computernumbers1 = new Random();
                            game.ComputerDice = Computernumbers1.Next(1, 7);

                            if (game.ComputerDice > game.Computerscore)
                            {
                                game.Computerscore = game.ComputerDice;
                            }

                            Console.WriteLine(game.ComputerDice);
                        }

                        Console.WriteLine("Computer's score is:" + game.Computerscore);
                        Console.WriteLine("Computer rolls two dice");

                        // Display two random numbers
                        Random Computernumbers2 = new Random();
                        for (int numbercount = 0; numbercount < 2; numbercount++)
                        {
                            game.ComputerDice = Computernumbers2.Next(1, 7);

                            if (game.ComputerDice > game.Computerscore2)
                            {
                                game.Computerscore2 = game.ComputerDice;
                            }

                            Console.WriteLine(game.ComputerDice);
                        }
                            Console.WriteLine("Computer's score is: " + game.Computerscore2);
                            Console.WriteLine("Computer rolls die:");

                            //Display one random number for Player 2

                            Random Computernumbers3 = new Random();

                            game.ComputerDice = Computernumbers3.Next(1, 7);

                            if (game.ComputerDice > game.Computerscore3)
                            {
                                game.Computerscore3 = game.ComputerDice;


                                Console.WriteLine(game.ComputerDice);
                            }

                            Console.WriteLine("Computer's score is:" + game.Computerscore3);

                            // Adds scores from Round 1 and displays playe 2's total score for Round 1 

                            game.ComputerTotalscore = (game.Computerscore + game.Computerscore2 + game.ComputerDice);
                            Console.WriteLine("Computer's total score is: " + game.ComputerTotalscore);
                            Console.WriteLine("\n");


                            game.Player1score = 0;
                            game.Player1score2 = 0;
                            game.Player1score3 = 0;


                            game.Computerscore = 0;
                            game.Computerscore2 = 0;
                            game.Computerscore3 = 0;


                            // Adds scores from Round 2 and displays player 2's total score for Round 2 

                            if (game.Player1Totalscore > game.ComputerTotalscore)
                            {
                                game.Player1winsRound.Player1Round = game.Player1winsRound.Player1Round + 1;
                                Console.WriteLine(game.Player1 + " wins round " + Convert.ToString(game.RoundNum2));
                                game.Round2 = false;


                            }

                            else
                            {
                                game.ComputerwinsRound.Player2Round = game.ComputerwinsRound.ComputerRound + 1;
                                Console.WriteLine("Computer wins round " + Convert.ToString(game.RoundNum2));
                                game.Round2 = false;


                                if (game.Player1winsRound.Player1Round == 5)
                                {

                                    Console.WriteLine(game.Player1 + " wins game");
                                    Console.WriteLine("\nClick Enter to restart");
                                    Console.ReadLine();
                                    game.Playing2 = false;


                                }
                                else if (game.ComputerwinsRound.ComputerRound == 5)
                                {
                                    Console.WriteLine("Computer wins game");

                                    Console.WriteLine("\nClick Enter to restart");
                                    Console.ReadLine();
                                    game.Playing2 = false;

                                }

                            }
                        }

                    }
                }

            }

        }
    }
