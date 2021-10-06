using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Gambler
    {
        public int stake = 100;
        public int bet = 1;
        public int  betCount=0;

        public void Betting()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if(check==0)
            {
                betCount = stake + 1;
                Console.WriteLine("Player Won the Game");
            }
            else
            {
                betCount = stake - 1;
                Console.WriteLine("Player Loose the Game");
            }

        }
    }
}

