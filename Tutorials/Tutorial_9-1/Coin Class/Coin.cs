using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Class
{
    class Coin
    {
        private string whichSide;
        Random Rand = new Random();

        public Coin()
        {
            whichSide = "Heads";
        }

        public void Toss()
        {

            if (Rand.Next(2) == 0)
            {
                whichSide = "Heads";
            }

            else
            {
                whichSide = "Tails";
            }

        }

        public string GetSide()
        {
            return whichSide;
        }

    }
}
