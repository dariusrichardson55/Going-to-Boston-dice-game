using System;
using Match_Play_Game;
using Score_Play_Game;
using Computer_Match_Play_Game;
using Computer_Score_Play_Game;

// Title: Going to Boston dice game: Written by Darius Richardson:
// It was written at  27/11/2017
// It was written at 30/11/2017
// Updated version of the game: 08/08/2021

namespace Game
{
    public class Game_Play
    {       
        public string Player1, Player2;

        public bool Playing = true, Playing2 = true;

        public int Player1Dice, Player2Dice, ComputerDice;

        public int Player1winsRound, Player2winsRound, ComputerwinsRound;

        public bool Round = true, Round2 = true;
        
        public int RoundNum, RoundNum2;
        
        public int Player1Points, Player2Points, ComputerPoints;

        public static void Play()
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
        static void Main(string[] args)
        {
            Play();
        }
    }
}

















