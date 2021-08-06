using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Going_to_Boston_dice_game;
using Game;

namespace Match_Play_Game
{
    public class Match_Play
    {
        public static void Match()
        {
            var game = new Game_Play();


            // Allows user to enter name of Player 1 and Player2
            game.Player1 = Util.Console.Ask("Enter name of Player 1");

            game.Player2 = Util.Console.Ask("Enter name of Player 2");

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
                            Console.WriteLine(game.Player1 + " ,press enter to roll three dice");
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
                            Console.WriteLine(game.Player1 + " ,your score is:" + game.Player1score);

                            // Message for Player 1
                            Console.WriteLine(game.Player2 + " ,press enter to roll two dice");
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

                            Console.WriteLine(game.Player1 + " ,your score is:" + game.Player1score2);
                            Console.WriteLine("\n");

                            /// Display one random number for Player 1

                            Console.WriteLine(game.Player1 + " ,press enter to roll a die:");
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
                            Console.WriteLine(game.Player1 + ",your score is:" + game.Player1Dice);
                            Console.WriteLine("\n");


                            game.Player1Totalscore = (game.Player1score + game.Player1score2 + game.Player1score3);
                            Console.WriteLine(game.Player1 + " your total score is:" + game.Player1Totalscore);


                            /// Display three random numbers for Player 2
                            Console.WriteLine(game.Player2 + " ,your turn:");
                            Console.WriteLine(game.Player2 + " ,press enter to roll three dice:");
                            Console.ReadLine();

                            Random Player2numbers1 = new Random();
                            for (int numbercount = 0; numbercount < 3; numbercount++)
                            {


                                game.Player2Dice = Player2numbers1.Next(1, 7);

                                if (game.Player2Dice > game.Player2score)
                                {
                                    game.Player2score = game.Player2Dice;

                                }


                                Console.WriteLine(game.Player2Dice);

                            }

                            Console.WriteLine(game.Player2 + " ,your score is:" + game.Player2score);



                            Console.WriteLine(game.Player2 + " ,Press enter to roll two dice:");
                            Console.ReadLine();

                            // Display two random numbers
                            Random Player2numbers2 = new Random();
                            for (int numbercount = 0; numbercount < 2; numbercount++)
                            {
                                game.Player2Dice = Player2numbers2.Next(1, 7);

                                if (game.Player2Dice > game.Player2score2)
                                {
                                    game.Player2score2 = game.Player2Dice;


                                }

                                Console.WriteLine(game.Player2Dice);

                            }

                            Console.WriteLine(game.Player2 + " ,your score is:" + game.Player2score2);

                            Console.WriteLine(game.Player2 + " ,Press enter to roll die:");
                            Console.ReadLine();



                            // Display one random number for Player 2
                            Random Player2numbers3 = new Random();
                            for (int numbercount = 0; numbercount < 1; numbercount++)
                            {
                                game.Player2Dice = Player2numbers3.Next(1, 7);


                                if (game.Player1Dice > game.Player1score3)
                                {
                                    game.Player2score3 = game.Player1Dice;
                                }

                                Console.WriteLine(game.Player2Dice);
                            }


                            Console.WriteLine(game.Player2 + " ,your score is:" + game.Player2Dice);


                            // Adds scores from Round 1 and displays player 2's total score for Round 1 


                            game.Player2Totalscore = (game.Player2score + game.Player2score2 + game.Player2Dice);
                            Console.WriteLine(game.Player2 + " your total score is:" + game.Player2Totalscore);
                            Console.WriteLine("\n");

                            // Adds scores from Round 2 and displays player 2's total score for Round 2 



                            if (game.Player1Totalscore > game.Player2Totalscore)
                            {
                                game.Player1winsRound.Player1Round = game.Player1winsRound.Player1Round + 1;
                                game.Player1Points++;
                                Console.WriteLine(game.Player1 + " wins round " + Convert.ToString(game.RoundNum));
                                Console.WriteLine(game.Player1 + " points:" + Convert.ToString(game.Player1Points));
                                game.Round = false;

                            }

                            else if (game.Player1Totalscore < game.Player2Totalscore)
                            {
                                game.Player2winsRound.Player2Round = game.Player2winsRound.Player2Round + 1;
                                game.Player2Points++;
                                Console.WriteLine(game.Player2 + " wins round " + Convert.ToString(game.RoundNum));
                                Console.WriteLine(game.Player2 + " points:" + Convert.ToString(game.Player2Points));
                                game.Round = false;
                            
                        }

                        game.Player1Totalscore = 0;
                        game.Player2Totalscore = 0;

                        game.Player1score = 0;
                        game.Player1score2 = 0;
                        game.Player1score3 = 0;

                        game.Player2score = 0;
                        game.Player2score2 = 0;
                        game.Player2score3 = 0;

                        if (game.Player1winsRound.Player1Round == 5)
                            {
                                Console.WriteLine(game.Player1 + " win's game");
                                Console.WriteLine("\nClick Enter to restart");
                                Console.ReadLine();
                                game.Playing = false;
                            }

                            else if (game.Player2winsRound.Player2Round == 5)
                            {
                                Console.WriteLine(game.Player2 + " win's game");
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


