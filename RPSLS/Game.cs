﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        //member variables (Has A)
        public Player player1;
        public Player player2;

        //constructor
        public Game()
        {
        
        }

        //member methods (Can Do)
        public void GameSetup()
        {
            ChooseHowManyPlayers();
            PlayGame();
        }

        public void PlayGame()
        {
            MakeChoice();
            CompareGestures();
            CheckIfGameWinner();
        }

        public void ChooseHowManyPlayers()
        {
            Console.WriteLine("How many players?");
            string UserInputHowMany = Console.ReadLine();
                if(UserInputHowMany == "1")
                {
                player1 = new Human();
                player2 = new Computer();
                }
                else if(UserInputHowMany == "2")
                {
                player1 = new Human();
                player2 = new Human();
                }
        }

       public void CompareGestures()
        {
            if (player1.gesture == "rock" && player2.gesture == "scissors")
            {
                Console.WriteLine("Rock crushes scissors! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "rock" && player1.gesture == "scissors")
            {
                Console.WriteLine("Rock crushes scissors! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "scissors" && player2.gesture == "paper")
            {
                Console.WriteLine("Scissors cuts paper! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "scissors" && player1.gesture == "paper")
            {
                Console.WriteLine("Scissors cuts paper! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "paper" && player2.gesture == "rock")
            {
                Console.WriteLine("Paper covers rock! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "paper" && player1.gesture == "rock")
            {
                Console.WriteLine("Paper covers rock! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "rock" && player2.gesture == "lizard")
            {
                Console.WriteLine("Rock crushes lizard! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "rock" && player1.gesture == "lizard")
            {
                Console.WriteLine("Rock crushes lizard! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "lizard" && player2.gesture == "spock")
            {
                Console.WriteLine("Lizard poisons spock! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "lizard" && player1.gesture == "spock")
            {
                Console.WriteLine("Lizard poisons spock! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "spock" && player2.gesture == "scissors")
            {
                Console.WriteLine("Spock smashes scissors! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "spock" && player1.gesture == "scissors")
            {
                Console.WriteLine("Spock smashes scissors! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "scissors" && player2.gesture == "lizard")
            {
                Console.WriteLine("Scissors decapitates lizard! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "scissors" && player1.gesture == "lizard")
            {
                Console.WriteLine("Scissors decapitates lizard! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "lizard" && player2.gesture == "paper")
            {
                Console.WriteLine("Lizard eats paper! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "lizard" && player1.gesture == "paper")
            {
                Console.WriteLine("Lizard eats paper! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "paper" && player2.gesture == "spock")
            {
                Console.WriteLine("Paper disproves spock! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "paper" && player1.gesture == "spock")
            {
                Console.WriteLine("Paper disproves spock! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == "spock" && player2.gesture == "rock")
            {
                Console.WriteLine("Spock vaporizes rock! Round point goes to {0}!", player1.name);
                player1.score++;
            }
            if (player2.gesture == "spock" && player1.gesture == "rock")
            {
                Console.WriteLine("Spock vaporizes rock! Round point goes to {0}!", player2.name);
                player2.score++;
            }
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie! Try again.");
                
            }
        }

        public void CheckIfGameWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("CONGRATS {0}! You are the game champion! Press any key to exit.", player1.name);
                Console.ReadLine();
            }
            if (player2.score == 2)
            {
                Console.WriteLine("CONGRATS {0}! You are the game champion! Press any key to exit.", player2.name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Next round!");
                PlayGame();
            }
        }

        public void MakeChoice()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        public void RestartGame()
        {

        }

        public void NoteToPlayer()
        {
            Console.ReadLine();
        }

    }
}
