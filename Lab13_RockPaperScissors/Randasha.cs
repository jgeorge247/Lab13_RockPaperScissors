using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    class Randasha : Player
    {
        public Randasha()
        {
            Name = ("Randasha");
        }
        override public Roshambo generateRoshambo()
        {
            Random Bob = new Random();
            int Jim = Bob.Next(0, 2);
            int x = (int)Roshambo.rock;
            int y = (int)Roshambo.paper;
            int z = (int)Roshambo.scissors;

            if (Jim == x)
            {
                return Roshambo.rock;
            }
            else if (Jim == y)
            {
                return Roshambo.paper;
            }
            else 
            {
                return Roshambo.scissors;
            }
         
        }
    }
}
