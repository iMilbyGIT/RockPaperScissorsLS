using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    class Scissor : Gestures
    {

        public Scissor(string name) : base(name)
        {

        }

        public override string Compare(Gestures gestures)
        {
            if (gestures.Name == "Paper" || gestures.Name == "Lizard")
            {
                return "Win";
            }
            else if (gestures.Name == Name){
                return "Tie";
            }
            else{
                return "Lose";

            }
        }

    }
}
