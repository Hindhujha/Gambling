using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GamblingGame
{
    public class WinOrLose
    {
        public void display()
        {

            Random random = new Random();
            int bet = random.Next(0, 2);

            if (bet == 1)
            {
                Console.WriteLine("GAMBLER WIN 1 DOLLAR");
            }
            else
            {
                Console.WriteLine("GAMBLER LOSS 1 DOLLAR");
            }
        }
    }
}
