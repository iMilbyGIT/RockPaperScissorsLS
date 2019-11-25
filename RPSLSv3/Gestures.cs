using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    public abstract class Gestures
    {
        public string Name;

        public Gestures(string name)
        {
            Name = name;
        }


        public abstract string Compare(Gestures gestures);

    }

}


