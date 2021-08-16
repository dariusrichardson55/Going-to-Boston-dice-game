using System;
using System.Threading;
using Game;
using Players;

namespace Computer_Score_Play_Game
{
    public class Computer_Score_Play
    {
        public static void Computer_Score()
        { 

            Game_Play game = new Game_Play();
            Player player = new Player();

            game.Player1 = Util.Console.Ask("Enter name of Player 1");

            while (game.Playing2)
            {
               try { 
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

                            if (game.Player1Dice > player.Player1score)
                            {
                                player.Player1score = game.Player1Dice;

                            }

                            Console.WriteLine(game.Player1Dice);


                        }

                        /// Dispalys maxiumn number (Player 1's score) from three random numbers

                        Console.WriteLine(game.Player1 + " your score is " + player.Player1score);


                        // Message for Player 1
                        Console.WriteLine(game.Player1 + " press enter to roll two dice");
                        Console.ReadLine();

                        /// Display two random numbers for Player 1

                        Random Player1numbers2 = new Random();
                        for (int numbercount = 0; numbercount < 2; numbercount++)
                        {
                            game.Player1Dice = Player1numbers2.Next(1, 7);


                            if (game.Player1Dice > player.Player1score2)
                            {
                                player.Player1score2 = game.Player1Dice;
                            }


                            Console.WriteLine(game.Player1Dice);

                        }

                        /// Dispalys maxiumn number (Player 1's score)sz from three random numbers
                        Console.WriteLine(game.Player1 + " your score is:" + player.Player1score2);

                        /// Display one random number for Player 1

                        Console.WriteLine(game.Player1 + " press enter to roll a die:");
                        Console.ReadLine();

                        // Finds maxiumn numbers from random numbers
                        Random Player1numbers3 = new Random();
                        for (int numbercount = 0; numbercount < 1; numbercount++)
                        {
                            game.Player1Dice = Player1numbers3.Next(1, 7);

                            if (game.Player1Dice > player.Player1score3)
                            {
                                player.Player1score3 = game.Player1Dice;
                            }

                            Console.WriteLine(game.Player1Dice);

                            /// Dispalys maxiumn number (Player 1's score)
                            Console.WriteLine(game.Player1 + " your score is:" + game.Player1Dice);

                            Console.WriteLine("\n");
                        }

                        player.Player1Totalscore = (player.Player1score + player.Player1score2 + game.Player1Dice);
                        Console.WriteLine(game.Player1 + " your total score is:" + player.Player1Totalscore);
                        Console.WriteLine("Computer's turn, please wait");
                        Thread.Sleep(4000);

                        /// Display three random numbers for Player 2                   
                        Console.WriteLine("Computer rolls three dice");

                        for (int numbercount = 0; numbercount < 3; numbercount++)
                        {

                            Random Computernumbers1 = new Random();
                            game.ComputerDice = Computernumbers1.Next(1, 7);

                            if (game.ComputerDice > player.Computerscore)
                            {
                                player.Computerscore = game.ComputerDice;
                            }

                            Console.WriteLine(game.ComputerDice);
                        }

                        Console.WriteLine("Computer's score is:" + player.Computerscore);
                        Console.WriteLine("Computer rolls two dice");

                        // Display two random numbers
                        Random Computernumbers2 = new Random();
                        for (int numbercount = 0; numbercount < 2; numbercount++)
                        {
                            game.ComputerDice = Computernumbers2.Next(1, 7);

                            if (game.ComputerDice > player.Computerscore2)
                            {
                                player.Computerscore2 = game.ComputerDice;
                            }

                            Console.WriteLine(game.ComputerDice);
                        }
                            Console.WriteLine("Computer's score is: " + player.Computerscore2);
                            Console.WriteLine("Computer rolls die:");

                            //Display one random number for Player 2

                            Random Computernumbers3 = new Random();

                            game.ComputerDice = Computernumbers3.Next(1, 7);

                            if (game.ComputerDice > player.Computerscore3)
                            {
                                player.Computerscore3 = game.ComputerDice;

                                Console.WriteLine(game.ComputerDice);
                            }

                            Console.WriteLine("Computer's score is:" + player.Computerscore3);

                            // Adds scores from Round 1 and displays playe 2's total score for Round 1 

                            player.ComputerTotalscore = (player.Computerscore + player.Computerscore2 + game.ComputerDice);
                            Console.WriteLine("Computer's total score is: " + player.ComputerTotalscore);
                            Console.WriteLine("\n");


                        // Adds scores from Round 2 and displays player 2's total score for Round 2 

                        if (player.Player1Totalscore > player.ComputerTotalscore)
                            {
                                game.Player1winsRound = game.Player1winsRound + 1;
                                Console.WriteLine(game.Player1 + " wins round " + Convert.ToString(game.RoundNum2));
                                player = new Player(); 
                                game.Round2 = false;

                        }

                        else
                            {
                                game.Player2winsRound = game.ComputerwinsRound + 1;
                                Console.WriteLine("Computer wins round " + Convert.ToString(game.RoundNum2));
                                player = new Player();
                                game.Round2 = false;

                                if (game.Player1winsRound == 5)
                                {

                                    Console.WriteLine(game.Player1 + " wins game");
                                    Console.WriteLine("\nClick Enter to restart");
                                    Console.ReadLine();
                                    Game_Play.Play();


                                }
                                else if (game.ComputerwinsRound == 5)
                                {
                                    Console.WriteLine("Computer wins game");

                                    Console.WriteLine("\nClick Enter to restart");
                                    Console.ReadLine();
                                    Game_Play.Play();

                                }

                            }
                        }

                    }
                catch (DivideByZeroException e)

                {
                    Console.WriteLine(String.Format("0:{0}", Convert.ToString(e)));

                }
                catch (Exception e)

                {
                    Console.WriteLine(String.Format("0:{0}", Convert.ToString(e)));

                }
                finally

                {
                    Console.WriteLine("Done with exception handling");
                }
            }

            }

        }
    }
