using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperV2
{
    class Human
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
