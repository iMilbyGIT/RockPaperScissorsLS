using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    abstract public class Player
    {

        public int score;
        public List<string> choices;
        public string name;
        public List<string> gestures;
        public string gesture;
        public string gestureInput;
        public abstract void ChooseGesture();
        public abstract void ChooseName();



        List<string> gestureChoices = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" }; 






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
