using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    class User : Player
    {
        public User (string n) : base (n)
        {
          
        }
        override public Roshambo generateRoshambo()
        {
            Console.WriteLine("Please pick one of the following:");
            Console.WriteLine("\nRock, Paper, Scissors (R/P/S)");
            string UserInput = Console.ReadLine().ToUpper();

            while (UserInput != "R" && UserInput != "P" && UserInput != "S")
            {
                Console.WriteLine("That is not a valid input. Please try again.");
                UserInput = Console.ReadLine().ToUpper();
            }
            //else if (UserInput == "R" || UserInput == "P" || UserInput == "S")
            //{
               
            //}

            if (UserInput == "R")
            {
                return Roshambo.rock;
            }
            else if (UserInput == "P")
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
