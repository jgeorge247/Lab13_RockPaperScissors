using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    class RockyBalboa : Player
    {
        public RockyBalboa(string n) : base (n)
        {

        }
        override public Roshambo generateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
