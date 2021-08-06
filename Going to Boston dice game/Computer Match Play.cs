using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Going_to_Boston_dice_game;
using System.Threading;
using Game;

namespace Going_to_Boston_dice_game
{
    public class Computer_Match_Play
    {
        public static void Computer_Match()
        {
            var game = new Game_Play();


            // Allows user to enter name of Player 1 and Player2
            game.Player1 = Util.Console.Ask("Please enter your name");

            try
            {
                while (game.Playing)
                {

                    //// Continue Program 9 times

                    while (game.RoundNum < 9)
                    {
                        // Starts Round 1 

                        game.RoundNum++;

                        // Message for Player 1
                        Console.WriteLine(game.Player1 + ",press enter to roll three dice");
                        Console.ReadLine();

                        // Display three random numbers from 1 to 6 for Player 1

                        Random Player1numbers1 = new Random();

                        for (int numbercount = 0; numbercount < 3; numbercount++)
                        {
                            game.Player1Dice = Player1numbers1.Next(1, 7);


                            if (game.Player1Dice > game.Player1score)
                            {
                                game.Player1score = game.Player1Dice;

                            }

                            Console.WriteLine(game.Player1Dice);
                        }
                        Console.WriteLine(game.Player1 + ",your score is:" + game.Player1score);

                        // Message for Player 1
                        Console.WriteLine(game.Player1 + ",press enter to roll two dice");
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

                        Console.WriteLine(game.Player1 + ",your score is:" + game.Player1score2);
                        Console.WriteLine("\n");

                        /// Display one random number for Player 1

                        Console.WriteLine(game.Player1 + ",press enter to roll a die:");
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

                        }
                        Console.WriteLine(game.Player1 + ", your score is:" + game.Player1Dice);
                        Console.WriteLine("\n");


                        game.Player1Totalscore = (game.Player1score + game.Player1score2 + game.Player1score3);
                        Console.WriteLine(game.Player1 + ", your total score is:" + game.Player1Totalscore);
                        Console.WriteLine("Computer's turn, please wait");
                        Thread.Sleep(4000);

                        /// Display three random numbers for Computer
                        Console.WriteLine("Computer rolls three dice");

                        Random Computernumbers1 = new Random();
                        for (int numbercount = 0; numbercount < 3; numbercount++)
                        {

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

                        Console.WriteLine("Computer's score is:" + game.Computerscore2);
                        Console.WriteLine("Computer rolls die");

                        // Display one random number for Player 2
                        Random Computernumbers3 = new Random();
                        for (int numbercount = 0; numbercount < 1; numbercount++)
                        {
                            game.ComputerDice = Computernumbers3.Next(1, 7);


                            if (game.ComputerDice > game.Computerscore3)
                            {
                                game.Computerscore3 = game.ComputerDice;
                            }

                            Console.WriteLine(game.ComputerDice);

                        }


                        Console.WriteLine("computer's score is:" + game.ComputerDice);



                        // Total score of Computer
                        game.ComputerTotalscore = (game.Computerscore + game.Computerscore2 + game.ComputerDice);
                        Console.WriteLine("Computer's total score is:" + game.ComputerTotalscore);
                        Console.WriteLine("\n");

                        // Adds scores from Round 2 and displays player 2's total score for Round 2 



                        if (game.Player1Totalscore > game.ComputerTotalscore)
                        {
                            game.Player1winsRound.Player1Round = game.Player1winsRound.Player1Round + 1;
                            game.Player1Points++;
                            Console.WriteLine(game.Player1 + " wins round " + Convert.ToString(game.RoundNum));
                            Console.WriteLine(game.Player1 + " points:" + Convert.ToString(game.Player1Points));
                            game.Round = false;

                        }

                        else if (game.Player1Totalscore < game.ComputerTotalscore)
                        {
                            game.ComputerwinsRound.Player2Round = game.ComputerwinsRound.ComputerRound + 1;
                            game.ComputerPoints++;
                            Console.WriteLine("Computer wins round " + Convert.ToString(game.RoundNum));
                            Console.WriteLine("Computer's points:" + Convert.ToString(game.ComputerPoints));
                            game.Round = false;

                        }

                        game.ComputerTotalscore = 0;
                        game.ComputerTotalscore = 0;

                        game.Computerscore = 0;
                        game.Computerscore2 = 0;
                        game.Computerscore3 = 0;

                        game.Computerscore = 0;
                        game.Computerscore2 = 0;
                        game.Computerscore3 = 0;

                        if (game.Player1winsRound.Player1Round == 5)
                        {
                            Console.WriteLine(game.Player1 + " win's game");
                            Console.WriteLine("\nClick Enter to restart");
                            Console.ReadLine();
                            game.Playing = false;
                        }

                        else if (game.ComputerwinsRound.ComputerRound == 5)
                        {
                            Console.WriteLine("Computer win's game");
                            Console.WriteLine("\nClick Enter to restart");
                            Console.ReadLine();
                            game.Playing = false;
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