using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class ShowUserGuessResult
    {
        public void PrintToConsole(HandleUserGuess handleUserGuess, bool isWinningGuess)
        {
            if (isWinningGuess)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }

            if (handleUserGuess.Count == 3)
            {
                Console.WriteLine("You Lose");
            }
        }
    }
}
