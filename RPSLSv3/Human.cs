using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    public class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("What will you choose? Rock, Paper, Scissor, Lizard, or Spock?");
            gestureInput = Console.ReadLine();
             		switch(gestureInput)
                  {
             			case "rock":
                        
             			break;
             			case "paper":
             			
             			break;
             			case "scissor":
             			
             			break;
             			case "lizard":
             			
             			break;
             			case "spock":
             			
             			break;
             			default:
                        Console.WriteLine("That's not one of the options, please enter your move again.");
             			return;
             		}
             	
        }
        public override void ChooseName()
        {
            Console.WriteLine("choose a name");
            name = Console.ReadLine();
        }


    }
}
