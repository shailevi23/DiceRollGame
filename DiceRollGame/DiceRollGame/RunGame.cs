using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class RunGame
    {
        bool isUserWon;
        string input;
        UserInput userInput = new UserInput();
        HandleUserGuess handleUserGuess = new HandleUserGuess();
        ShowUserGuessResult showUserGuessResult = new ShowUserGuessResult();
        RollDice rollDice = new RollDice();

        public void Play()
        {
            int winningNumber = rollDice.GenerateRandomNumber();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            do
            {
                input = userInput.GetValidUserGuess();
                isUserWon = handleUserGuess.IsWinningGuess(input, winningNumber);
                showUserGuessResult.PrintToConsole(handleUserGuess, isUserWon);
            } while (handleUserGuess.Count < 3 && !isUserWon);

            return;
        }

    }
}
