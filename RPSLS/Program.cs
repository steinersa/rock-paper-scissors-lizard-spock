using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome with rules");
            Game newGame = new Game();
            newGame.PlayGame();
        }
    }
}
