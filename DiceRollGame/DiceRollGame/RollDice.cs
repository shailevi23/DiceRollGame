using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class RollDice
    {

        public int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        } 

    }
}
