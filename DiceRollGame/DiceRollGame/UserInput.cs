using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class UserInput
    {
        HandleIncorrectInput handleIncorrectInput;

        public UserInput()
        {
            handleIncorrectInput = new HandleIncorrectInput();
        }

        public string GetValidUserGuess()
        {
            string userInput;
            do
            {
                userInput = Console.ReadLine();
            } while (!IsInputValid(userInput));

            return userInput;
        }

        private bool IsInputValid(string input)
        {
            if (string.Empty.Equals(input))
            {
                handleIncorrectInput.PrintToConsole();
                return false;
            }
            else if (input.Length > 1)
            {
                handleIncorrectInput.PrintToConsole();
            }
            else
            {
                char charInput = Char.Parse(input);
                if (Char.IsLetter(charInput))
                {
                    handleIncorrectInput.PrintToConsole();
                    return false;
                }
            }

            return true;
        }
    }
}
