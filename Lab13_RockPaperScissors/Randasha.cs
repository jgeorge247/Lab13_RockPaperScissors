using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    class Randasha : Player
    {
        public Randasha(string n) : base (n)
        {
            
        }
        public override Roshambo generateRoshambo()
        {
            Random Bob = new Random();
            return (Roshambo)Bob.Next(3);
         
        }
    }
}
