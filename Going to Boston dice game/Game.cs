using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Match_Play_Game;
using Score_Play_Game;
using Going_to_Boston_dice_game;

// Title: Going to Boston dice game Written by Darius Richardson: It was written at 30/11/2017
// Updated version: 06/08/2021

namespace Game
{

    public class Game_Play
    {

        public string Player1 { get; set; }
        public string Player2 { get; set; }


        public int Player1Totalscore { get; set; } = 0;
        public int Player2Totalscore { get; set; } = 0;

        public int ComputerTotalscore { get; set; } = 0;


        public int Player1score { get; set; } = 0;
        public int Player1score2 { get; set; } = 0;
        public int Player1score3 { get; set; } = 0;

        public int Player2score { get; set; } = 0;
        public int Player2score2 { get; set; } = 0;
        public int Player2score3 { get; set; } = 0;

        public int Computerscore { get; set; } = 0;
        public int Computerscore2 { get; set; } = 0;
        public int Computerscore3 { get; set; } = 0;

        public bool Playing { get; set; } = true;

        public bool Playing2 { get; set; } = true;

        public int Player1Dice { get; set; }
        public int Player2Dice { get; set; }

        public int ComputerDice { get; set; }

        public Random random = new Random();

        public Round Player1winsRound = new Round();

        public Round Player2winsRound = new Round();

        public Round ComputerwinsRound = new Round();


        public bool Round { get; set; } = true;
        public bool Round2 { get; set; } = true;

        public int RoundNum { get; set; }
        public int RoundNum2 { get; set; }

        public int Player1Points { get; set; }

        public int Player2Points { get; set; }

        public int ComputerPoints { get; set; }

        public Match_Play match = new Match_Play();

        static void Main(string[] args)
        {
            Console.WriteLine("To play against Player (Press P) or to play against Computer (Press C)");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.P:
                    Playerselection();
                    break;

                    case ConsoleKey.C:
                    Computerselection();
                    break;

                default:
                    Console.WriteLine("You did not type the correct letter");
                    Console.ReadLine();
                    break;
            }
        }

        
        public static void Playerselection()
        {
            Console.WriteLine("\nYou have selected to play against Player");
            Console.WriteLine("To choose Match Play (Enter m) or to play Score Player (Enter s)");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.M: 
                    Console.WriteLine("\nYou chose Match Play:");
                    Match_Play.Match();
                    break;

                case ConsoleKey.S:
                    Console.WriteLine("\nYou chose Score Play:");
                    Score_Play.Score();
                    break;


            }
        }
        public static void Computerselection()
        {
            Console.WriteLine("\nYou have selected to play against Computer");
            Console.WriteLine("To choose Match Play (Enter m) or to play Score Player (Enter s)");
            
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.M:
                    Console.WriteLine("\nYou chose Match Play:");
                    Computer_Match_Play.Computer_Match();
                    break;

                case ConsoleKey.S:
                    Console.WriteLine("\nYou chose Score Play:");
                    Computer_Score_Play.Computer_Score();
                    break;


            }
        }

    }
}
















