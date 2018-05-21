using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Class
{
    class Coin
    {
        //Random object and a string to hold the result of the random object are created.
        private string whichSide;
        Random Rand = new Random();

        public Coin()
        {   //Coin state starts as heads.
            whichSide = "Heads";
        }

        public void Toss()
        {

            if (Rand.Next(2) == 0)
            {   //Random object is used that can only have two values. If one result, it does heads, else it does tails.
                whichSide = "Heads";
            }

            else
            {
                whichSide = "Tails";
            }

        }

        public string GetSide()
        {   //Returns the results of the coin flip.
            return whichSide;
        }

    }
}
