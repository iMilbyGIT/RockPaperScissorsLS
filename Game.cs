﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperV2
{
    public class Game
    {
        Player player1;
        Player player2;

        public string GetNumberPlayers()
        {
            Console.WriteLine("Time for a good ol' game of Rock-Paper-Scissors-Lizard-Spock! How many players? Enter 1 for solo play (human vs comp) or 2 for PvP (human vs human).");
            string numberPlayers = Console.ReadLine();
            if(numberPlayers == "1" || numberPlayers == "2")
            {
            return numberPlayers;
            }
            else{
                Console.WriteLine("Please enter an accurate number of players.");
                Console.ReadLine();
                GetNumberPlayers();
            }

        }
        public void CreatePlayers(string numberPlayers)
        {
            if(numberPlayers =="1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberPlayers =="2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }



    }


}

//        public playerType()
//        {
//            string CreatePlayers = Console.WriteLine("Time for a good ol' game of Rock-Paper-Scissors-Lizard-Spock! How many players? Enter 1 for solo play (human vs comp) or 2 for PvP (human vs human).  If you're a chicken that's okay too, just type abort to quit game.");
//            switch (playerTypeSelection)
//            {
//             case "1":
//             player1 = new Human();
//             player2 = new Computer();
//             break;
//             case "2":
//             player1 = new Human();
//             player2 = new Human();
//             break;
//             case "abort":
//             return;
//             break;
//             default:
//             Console.WriteLine("Sorry, I didn't understand what you just typed. Please re-enter your selection.");
//             return playerType;
//        }
//     }