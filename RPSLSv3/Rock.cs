using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    class Rock : Gestures
    {

        public Rock(string name) : base(name)
        {

        }
        public override string Compare(Gestures gestures)
        {
            if (gestures.Name == "Scissors" || gestures.Name == "Lizard")
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
