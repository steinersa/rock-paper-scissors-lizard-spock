using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This game is an adaptation of the classic Rock, Paper, Scissors match. Below you are asked to enter how many humans will be participating. Don't worry, if you are all alone, you get to play against the computer! You'll be prompted to tell the game a little bit about yourself, and then you'll move onto the first round. Best two out of three wins!" + Environment.NewLine + Environment.NewLine + "Who conquers who:" + Environment.NewLine + "Rock crushes Scissors" + Environment.NewLine + "Scissors cuts Paper" + Environment.NewLine + "Paper covers Rock" + Environment.NewLine + "Rock crushes Lizard" + Environment.NewLine + "Lizard poisons Spock" + Environment.NewLine + "Spock smashes Scissors" + Environment.NewLine + "Scissors decapitates Lizard" + Environment.NewLine + "Lizard eats Paper" + Environment.NewLine + "Paper disproves Spock" + Environment.NewLine + "Spock vaporizes Rock" + Environment.NewLine);
            Game newGame = new Game();
            newGame.GameSetup();
        }
    }
}
