using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("choose a gesture");
            gesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            Console.WriteLine("choose a name");
            name = Console.ReadLine();
        }







    }
}
