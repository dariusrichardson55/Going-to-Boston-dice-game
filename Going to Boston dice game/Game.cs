using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Match_Play_Game;

namespace Going_to_Boston_dice_game
{

     class Game
    {
        public static void Main()
        {
            Match_Play match_play = new Match_Play();

            match_play.Match();

            // Title: Going to Boston dice game Written by Darius Richardson: It was written at  30/11/2017

            // Intergers Players reset scores (Intergers) 

            
            // Total score
            int Player1Totalscore;
            int Player2Totalscore;

            int Player1score = 0;
            int Player1score2 = 0;
            int Player1score3 = 0;

            int Player2score = 0;
            int Player2score2 = 0;
            int Player2score3 = 0;


            Player Player1 = new Player();
            Player Player2 = new Player();


            Die Player1Dice = new Die();
            Die Player2Dice = new Die();

            Round Player1winsRound = new Round();
            Round Player2winsRound = new Round();


            bool Playing = true;
            bool Round = true;
            int RoundNum = 0;


            bool Playing2 = true;
            bool Round2 = true;
            int RoundNum2 = 0;

            int Player1Points = 0;
            int Player2Points = 0;

            // Choose between Match Play and Score Play
            start:
            Console.WriteLine("Do you want to play Match play(enter M) or score Play(enter S).");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.M:

                    Console.WriteLine("\nYou chose Match Play:");                               

                    // Allows user to enter name of Player 1 and Player2
                    Console.WriteLine("Enter Player 1:");
                    Player1.Name = Console.ReadLine();


                    Console.WriteLine("Enter Player 2:");
                    Player2.Name = Console.ReadLine();

                    {
                        {

                            {
                                try
                                {
                                   
                                    while (Playing)
                                    {
                                        while (Round)
                                        {
                                            while (RoundNum < 9)
                                            {
                                                //// Continue Program 9 times

                                                // Starts Round 1 

                                                RoundNum++;

                                                // Message for Player 1
                                                Console.WriteLine(Player1.Name + ",press enter to roll three dice");
                                                Console.ReadLine();

                                                // Display three random numbers from 1 to 6 for Player 1

                                                Random Player1numbers1 = new Random();
                                                for (int numbercount = 0; numbercount < 3; numbercount++)
                                                {
                                                    Player1Dice.Randomnumber1 = Player1numbers1.Next(1, 7);


                                                    if (Player1Dice.Randomnumber1 > Player1score)
                                                    {
                                                        Player1score = Player1Dice.Randomnumber1;

                                                    }

                                                    Console.WriteLine(Player1Dice.Randomnumber1);
                                                }
                                                    Console.WriteLine(Player1.Name + ",your score is:" + Player1score);

                                                // Message for Player 1
                                                Console.WriteLine(Player1.Name + ",press enter to roll two dice");
                                                Console.ReadLine();

                                                /// Display two random numbers for Player 1

                                                Random Player1numbers2 = new Random();
                                                for (int numbercount = 0; numbercount < 2; numbercount++)
                                                {
                                                    Player1Dice.Randomnumber2 = Player1numbers2.Next(1, 7);

                                                    if (Player1Dice.Randomnumber2 > Player1score2)
                                                    {
                                                        Player1score2 = Player1Dice.Randomnumber2;
                                                    }


                                                    Console.WriteLine(Player1Dice.Randomnumber2);

                                                }

                                                Console.WriteLine(Player1.Name + ",your score is:" + Player1score2);
                                                Console.WriteLine("\n");

                                                /// Display one random number for Player 1

                                                Console.WriteLine(Player1.Name + ",press enter to roll a die:");
                                                Console.ReadLine();

                                                // Finds maxiumn numbers from random numbers
                                                Random Player1numbers3 = new Random();
                                                for (int numbercount = 0; numbercount < 1; numbercount++)
                                                {
                                                    Player1Dice.Randomnumber3 = Player1numbers3.Next(1, 7);

                                                    if (Player1Dice.Randomnumber3 > Player1score3)
                                                    {
                                                        Player1score3 = Player1Dice.Randomnumber3;
                                                    }

                                                    Console.WriteLine(Player1Dice.Randomnumber3);

                                                }
                                                Console.WriteLine(Player1.Name + ",your score is:" + Player1Dice.Randomnumber3);
                                                Console.WriteLine("\n");


                                                Player1Totalscore = (Player1score + Player1score2 + Player1score3);
                                                Console.WriteLine(Player1.Name + " your total score is:" + Player1Totalscore);


                                                /// Display three random numbers for Player 2
                                                Console.WriteLine(Player2.Name + ",your turn:");
                                                Console.WriteLine(Player2.Name + ",press enter to roll three dice:");
                                                Console.ReadLine();

                                                Random Player2numbers1 = new Random();
                                                for (int numbercount = 0; numbercount < 3; numbercount++)
                                                {


                                                    Player2Dice.Randomnumber4 = Player2numbers1.Next(1, 7);

                                                    if (Player2Dice.Randomnumber4 > Player2score)
                                                    {
                                                        Player2score = Player2Dice.Randomnumber4;

                                                    }


                                                    Console.WriteLine(Player2Dice.Randomnumber4);

                                                }

                                                Console.WriteLine(Player2.Name + ",your score is:" + Player2score);



                                                Console.WriteLine(Player2.Name + ",Press enter to roll two dice:");
                                                Console.ReadLine();

                                                // Display two random numbers
                                                Random Player2numbers2 = new Random();
                                                for (int numbercount = 0; numbercount < 2; numbercount++)
                                                {
                                                    Player2Dice.Randomnumber5 = Player2numbers2.Next(1, 7);

                                                    if (Player2Dice.Randomnumber5 > Player2score2)
                                                    {
                                                        Player2score2 = Player2Dice.Randomnumber5;


                                                    }

                                                    Console.WriteLine(Player2Dice.Randomnumber5);

                                                }

                                                Console.WriteLine(Player2.Name + ",your score is:" + Player2score2);

                                                Console.WriteLine(Player2.Name + ",Press enter to roll die:");
                                                Console.ReadLine();



                                                // Display one random number for Player 2
                                                Random Player2numbers3 = new Random();
                                                for (int numbercount = 0; numbercount < 1; numbercount++)
                                                {
                                                    Player2Dice.Randomnumber6 = Player2numbers3.Next(1, 7);


                                                    if (Player1Dice.Randomnumber3 > Player1score3)
                                                    {
                                                        Player2score3 = Player1Dice.Randomnumber6;
                                                    }

                                                      Console.WriteLine(Player2Dice.Randomnumber6);
                                                }

                                                
                                                Console.WriteLine(Player2.Name + ",your score is:" + Player2Dice.Randomnumber6);


                                                // Adds scores from Round 1 and displays player 2's total score for Round 1 


                                                Player2Totalscore = (Player2score + Player2score2 + Player2Dice.Randomnumber6);     
                                                Console.WriteLine(Player2.Name + " your total score is:" + Player2Totalscore);
                                                Console.WriteLine("\n");
                                           
                                                // Adds scores from Round 2 and displays player 2's total score for Round 2 

                                                
                                                
                                                if (Player1Totalscore > Player2Totalscore)
                                                {
                                                    Player1winsRound.Player1Round = Player1winsRound.Player1Round + 1;
                                                    Player1Points++;
                                                    Console.WriteLine(Player1.Name + " wins round " + Convert.ToString(RoundNum));
                                                    Console.WriteLine(Player1.Name + " points:" + Convert.ToString(Player1Points));
                                                    Round = false;
                                                    
                                                }
                                            
                                                else if (Player1Totalscore < Player2Totalscore)
                                                {
                                                    Player2winsRound.Player2Round = Player2winsRound.Player2Round + 1;
                                                    Player2Points++;
                                                    Console.WriteLine(Player2.Name + " wins round " + Convert.ToString(RoundNum));
                                                    Console.WriteLine(Player2.Name + " points:" + Convert.ToString(Player2Points));
                                                    Round = false;
                                                }
                                                 Player1Totalscore = 0;
                                                 Player2Totalscore = 0;

                                                 Player1score = 0;
                                                 Player1score2 = 0;
                                                 Player1score3 = 0;


                                                 Player2score = 0;
                                                 Player2score2 = 0;
                                                 Player2score3 = 0;

                                                if (Player1winsRound.Player1Round == 5)
                                                {
                                                    Console.WriteLine(Player1.Name + " win's game");
                                                    Console.ReadLine();
                                                    Playing = false;
                                                    break;

                                                }

                                                else if (Player2winsRound.Player2Round == 5)
                                                {
                                                    Console.WriteLine(Player2.Name + " win's game");
                                                    Console.ReadLine();
                                                    Playing = false;
                                                    break;

                                                }
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
                        break;

                    }

           
                // Score Plays
                case ConsoleKey.S:


                    Console.WriteLine("\nYou chose Score Play:");

                    Console.WriteLine("Enter Player 1:");
                    Player1.Name = Console.ReadLine();


                    Console.WriteLine("Enter Player 2:");
                    Player2.Name = Console.ReadLine();

                   
                        while (Playing2)
                        {

                            while (Round2)
                            {
                            while (RoundNum2 < 9)

                            {
                                // Starts Round 1 of score Play 
                                RoundNum2++;
                                // Message for Player 1
                                Console.WriteLine(Player1.Name + " press enter to roll three dice");
                                Console.ReadLine();

                                // Display three random numbers from 1 to 6 for Player 1

                                Random Player1numbers1 = new Random();
                                for (int numbercount = 0; numbercount < 3; numbercount++)
                                {
                                    Player1Dice.Randomnumber7 = Player1numbers1.Next(1, 7);

                                    /// Finds maxiumn number out of the three random numbers

                                    if (Player1Dice.Randomnumber7 > Player1score)
                                    {
                                        Player1score = Player1Dice.Randomnumber7;

                                    }

                                    Console.WriteLine(Player1Dice.Randomnumber7);


                                }

                                /// Dispalys maxiumn number (Player 1's score) from three random numbers

                                Console.WriteLine(Player1.Name + " your score is " + Player1score);


                                // Message for Player 1
                                Console.WriteLine(Player1.Name + " press enter to roll two dice");
                                Console.ReadLine();

                                /// Display two random numbers for Player 1

                                Random Player1numbers2 = new Random();
                                for (int numbercount = 0; numbercount < 2; numbercount++)
                                {
                                    Player1Dice.Randomnumber8 = Player1numbers2.Next(1, 7);


                                    if (Player1Dice.Randomnumber8 > Player1score2)
                                    {
                                        Player1score2 = Player1Dice.Randomnumber8;
                                    }


                                    Console.WriteLine(Player1Dice.Randomnumber8);

                                }

                                /// Dispalys maxiumn number (Player 1's score)sz from three random numbers
                                Console.WriteLine(Player1.Name + " your score is:" + Player1score2);





                                /// Display one random number for Player 1

                                Console.WriteLine(Player1.Name + " press enter to roll a die:");
                                Console.ReadLine();

                                // Finds maxiumn numbers from random numbers
                                Random Player1numbers3 = new Random();
                                for (int numbercount = 0; numbercount < 1; numbercount++)
                                {
                                    Player1Dice.Randomnumber9 = Player1numbers3.Next(1, 7);

                                    if (Player1Dice.Randomnumber9 > Player1score3)
                                    {
                                        Player1score3 = Player1Dice.Randomnumber9;
                                    }

                                    Console.WriteLine(Player1Dice.Randomnumber9);



                                    /// Dispalys maxiumn number (Player 1's score)
                                    Console.WriteLine(Player1.Name + " your score is:" + Player1Dice.Randomnumber9);


                                    Console.WriteLine("\n");


                                }


                                Player1Totalscore = (Player1score + Player1score2 + Player1Dice.Randomnumber9);
                                Console.WriteLine(Player1.Name + " your total score is:" + Player1Totalscore);


                                /// Display three random numbers for Player 2
                                Console.WriteLine(Player2.Name + " your turn:");
                                Console.WriteLine(Player2.Name + " press enter to roll three dice:");
                                Console.ReadLine();

                                for (int numbercount = 0; numbercount < 3; numbercount++)
                                {

                                    Random Player2numbers1 = new Random();
                                    Player2Dice.Randomnumber10 = Player2numbers1.Next(1, 7);

                                    if (Player2Dice.Randomnumber10 > Player2score)
                                    {
                                        Player2score = Player2Dice.Randomnumber10;
                                    }


                                    Console.WriteLine(Player2Dice.Randomnumber10);

                                }
                                Console.WriteLine(Player1.Name + " your score is:" + Player2score);



                                Console.WriteLine(Player2.Name + " press enter to roll two dice:");
                                Console.ReadLine();

                                // Display two random numbers
                                Random Player2numbers2 = new Random();
                                for (int numbercount = 0; numbercount < 2; numbercount++)
                                {
                                    Player2Dice.Randomnumber10 = Player2numbers2.Next(1, 7);

                                    if (Player2Dice.Randomnumber10 > Player2score2)
                                    {
                                        Player2score2 = Player2Dice.Randomnumber10;
                                    }


                                    Console.WriteLine(Player2Dice.Randomnumber10);

                                }
                                
                                    Console.WriteLine(Player2.Name + " your score is: " + Player2score2);
                            

                                Console.WriteLine(Player2.Name + " press enter to roll die:");
                                    Console.ReadLine();

                                    //Display one random number for Player 2

                                    Random Player2numbers3 = new Random();

                                    Player2Dice.Randomnumber11 = Player2numbers3.Next(1, 7);

                                    if (Player2Dice.Randomnumber11 > Player2score3)
                                    {
                                        Player2score3 = Player2Dice.Randomnumber11;


                                        Console.WriteLine(Player2Dice.Randomnumber11);


                                    }


                                    Console.WriteLine(Player2.Name + " your score is: " + Player2Dice.Randomnumber11);


                                    // Adds scores from Round 1 and displays playe 2's total score for Round 1 


                                    Player2Totalscore = (Player2score + Player2score2 + Player2Dice.Randomnumber11);
                                    Console.WriteLine(Player2.Name + " your total score is: " + Player2Totalscore);
                                    Console.WriteLine("\n");


                                Player1score = 0;
                                Player1score2 = 0;
                                Player1score3 = 0;


                                Player2score = 0;
                                Player2score2 = 0;
                                Player2score3 = 0;


                                // Adds scores from Round 2 and displays player 2's total score for Round 2 

                                if (Player1Totalscore > Player2Totalscore)
                                    {
                                        Player1winsRound.Player1Round = Player1winsRound.Player1Round + 1;
                                        Console.WriteLine(Player1.Name + " wins round " + Convert.ToString(RoundNum2));
                                        Round2 = false;


                                    }

                                    else
                                    {
                                        Player2winsRound.Player2Round = Player2winsRound.Player2Round + 1;
                                        Console.WriteLine(Player2.Name + " wins round " + Convert.ToString(RoundNum2));
                                        Round2 = false;

                                 
                                    if (Player1winsRound.Player1Round == 5)
                                    {

                                        Console.WriteLine(Player1.Name + " wins game");
                                        Console.WriteLine("\nClick Enter to restart");
                                        Console.ReadLine();
                                        Playing2 = false;
                                        goto start;


                                    }
                                    else if (Player2winsRound.Player2Round == 5)
                                    {
                                        Console.WriteLine(Player2.Name + " wins game");

                                        Console.WriteLine("\nClick Enter to restart");
                                        Console.ReadLine();
                                        Playing2 = false;
                                        goto start;

                                        }

                                    }
                                }

                            }
                        }
                        break;
                    }
                                                                              
            }
        }
    }




















