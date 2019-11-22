using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    class Paper : Gestures
    {

        public Paper(string name) : base(name)
        {

        }
        public override string Compare(Gestures gestures)
        {
            if (gestures.Name == "Rock" || gestures.Name == "Lizard")
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
