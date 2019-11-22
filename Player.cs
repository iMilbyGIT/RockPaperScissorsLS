using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperV2
{
    abstract public class Player
    {

        public int score;
        public List<string> choices;
        public string name;
        public List<string> gestures;

        public abstract void ChooseGesture(Gestures);
        public abstract void ChooseName();

        public void RunGame()
        {
            string input GetNumberPlayers();
            CreatePlayers(input);
            player1.ChooseGesture();
            player2.ChooseGesture();
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