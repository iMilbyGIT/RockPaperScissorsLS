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
        List<Gestures> gestures;

        abstract void ChooseGesture();
        abstract void ChooseName();

        public void RunGame()
        {
            string input GetNumberPlayers();
            CreatePlayers(input);
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        public Player()
        {
            gestures = new List<Gestures>();
        }

    }


}



// 	ChooseGesture = Console.WriteLine("What will you choose? Rock, Paper, Scissors, Lizard, or Spock?");
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