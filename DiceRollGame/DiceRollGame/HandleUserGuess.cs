using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class HandleUserGuess
    {
        public int Count { get; private set; }

        public HandleUserGuess()
        {
            Count = 0;
        }

        public bool IsWinningGuess(string userInput, int winningNumber)
        {
            IncreaseTurnsCounter();
            return int.Parse(userInput).Equals(winningNumber);
        }

        private void IncreaseTurnsCounter()
        {
            Count++;
        }
    }
}
