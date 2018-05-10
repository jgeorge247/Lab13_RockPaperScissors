using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    abstract class Player
    {
        private string name;
        private Roshambo magic;

        public string Name { get => name; set => name = value; }
        public Roshambo Magic { get => magic; set => magic = value; }

        public Player(string n) //n = name
        {
            Name = n;
        }

        abstract public Roshambo generateRoshambo();

    }
}
