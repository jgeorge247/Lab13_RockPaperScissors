using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13_RockPaperScissors
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Player MainUser;
            string UserName;

            {
                Console.WriteLine("\nPlease enter your name: ");
                UserName = Console.ReadLine();

                MainUser = new User(UserName);
            }
          

            Console.WriteLine("Would you like to play against Rocky Balboa or Randasha? (RB/R)");
            string Opponent = Console.ReadLine().ToUpper();

            Player O;
            Roshambo choice;

            string OpName;
            if (Opponent == "RB") //do validation
            {
                O = new RockyBalboa();
            }
            else //(Opponent == "R")
            {
                O = new Randasha();
            }
            choice = O.generateRoshambo();
            OpName = O.Name;


            Console.WriteLine($"{OpName} chose {choice}");

            MainUser.generateRoshambo();


            if (MainUser.generateRoshambo() == O.generateRoshambo())
            {
                Console.WriteLine("It's a draw!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.rock && O.generateRoshambo() == Roshambo.paper)
            {
                Console.WriteLine($"{OpName} wins!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.rock && O.generateRoshambo() == Roshambo.scissors)
            {
                Console.WriteLine("You win!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.paper && O.generateRoshambo() == Roshambo.rock)
            {
                Console.WriteLine($"{OpName} wins!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.paper && O.generateRoshambo() == Roshambo.scissors)
            {
                Console.WriteLine($"{OpName} wins!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.scissors && O.generateRoshambo() == Roshambo.paper)
            {
                Console.WriteLine("You win!");
            }
            else if (MainUser.generateRoshambo() == Roshambo.scissors && O.generateRoshambo() == Roshambo.rock)
            {
                Console.WriteLine($"{OpName} wins!");
            }


        }
        static bool Validate1(string UserName)
        {
            return Regex.IsMatch(UserName, @"[A-Za-z]\w{0,29}");
        }
    }
}
