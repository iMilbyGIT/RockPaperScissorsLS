using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperV2
{
    abstract class Player
    {

        public int score;
        public List<string> choices;
        public string name;
        public string gesture;

        abstract void ChooseGesture();
        abstract void ChooseName();

        public void RunGame()
        {
            string input GetNumberPlayers();
            CreatePlayers(input);
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

    }


}


//        public playerType()
//        {
//            string playerTypeSelection = Console.WriteLine("Time for a good ol' game of Rock-Paper-Scissors-Lizard-Spock! How many players? Enter 1 for solo play (human vs comp) or 2 for PvP (human vs human).  If you're a chicken that's okay too, just type abort to quit game.");
//            switch (playerTypeSelection)
//            {
//                case "1":
//                playerTypeSelection = NPCPlayer();
//                break;
//                case "2":
//              playerTypeSelection = HumanPlayer();
//                break;
//                case "abort":
//                return;
//                break;
//                default:
//                Console.WriteLine("Sorry, I didn't understand what you just typed. Please re-enter your selection.");
//                return playerType;
//           }
//
//        }


//        List<string> moveOptions = new List<string>();
//        moveOptions.Add("Rock");
//        moveOptions.Add("Paper");
//        moveOptions.Add("Scissors");
//        moveOptions.Add("Lizard");
//        moveOptions.Add("Spock");


// function move(){
// 	moveType = Console.WriteLine("What will you choose? Rock, Paper, Scissors, Lizard, or Spock?");
// 	string moveTypeSelection;
// 		switch(moveType)
//      {
// 			case "rock":
// 			moveTypeSelection =; // enter hard math here
// 			break;
// 			case "paper":
// 			moveTypeSelection =; // enter flimsy math here
// 			break;
// 			case "scissors" || "scissor":
// 			moveTypeSelection =; // enter sharpy math here
// 			break;
// 			case "lizard":
// 			moveTypeSelection =; // enter mark zuck math here
// 			break;
// 			case "spock":
// 			moveTypeSelection =; // enter clingon math here
// 			break;
// 			case "exit":
// 			return; 
// 			default:
// 			return;
// 		}
// 	}