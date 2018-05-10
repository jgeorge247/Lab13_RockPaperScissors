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

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nWould you like to play against Rocky Balboa or Randasha? (RB/R)");
                string Opponent = Console.ReadLine().ToUpper();
                while (Opponent != "RB" && Opponent != "R")
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                    Opponent = Console.ReadLine().ToUpper();
                }

                Player O;

                if (Opponent == "RB") //do validation
                {
                    O = new RockyBalboa("Rocky Balboa");
                }
                else //(Opponent == "R")
                {
                    O = new Randasha("Randasha");
                }
                O.Magic = O.generateRoshambo();
                MainUser.Magic = MainUser.generateRoshambo();
                Console.WriteLine($"\n{MainUser.Name} picked {MainUser.Magic}");
                Console.WriteLine($"{O.Name} picked {O.Magic}");


                if (MainUser.Magic == O.Magic)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if (MainUser.Magic == Roshambo.paper)
                {
                    if (O.Magic == Roshambo.scissors)
                    {
                        Console.WriteLine($"{O.Name} wins");
                    }
                    else
                    {
                        Console.WriteLine($"{MainUser.Name} wins");
                    }
                }
                else if (MainUser.Magic == Roshambo.rock)
                {
                    if (O.Magic == Roshambo.scissors)
                    {
                        Console.WriteLine($"{MainUser.Name} wins");
                    }
                    else
                    {
                        Console.WriteLine($"{O.Name} wins");
                    }
                }
                else if (MainUser.Magic == Roshambo.scissors)
                {
                    if (O.Magic == Roshambo.paper)
                    {
                        Console.WriteLine($"{MainUser.Name} wins");
                    }
                    else
                    {
                        Console.WriteLine($"{O.Name} wins");
                    }
                }
                Console.WriteLine("\nWould you like to play again? (Y/N)");
                string Response = Console.ReadLine().ToUpper();

                while (Response != "Y" && Response != "N")
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                    Response = Console.ReadLine().ToUpper();
                }
                repeat = false;
            }
        }
        static bool Validate1(string UserName)
        {
            return Regex.IsMatch(UserName, @"[A-Za-z]\w{0,29}");
        }
    }
}
