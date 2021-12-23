
using System;
namespace GamblingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int stake = 100; 
            int bet = 1;
            Console.WriteLine("GAMBLER STAKE FOR EVERDAY :" + stake);
            Console.WriteLine("GAMBLER BET:" + bet);
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.WIN/LOSE");
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        WinOrLose myObj = new WinOrLose();
                        myObj.display();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT OPTION");
                        break;

                }
            }
        }
                    

  }
    }


