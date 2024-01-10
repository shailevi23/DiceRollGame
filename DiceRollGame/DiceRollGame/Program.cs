using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame runGame = new RunGame();
            runGame.Play();

            //end game after pressing any key.
            Console.ReadLine();
        }
    }
}
