using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        //member variables (Has A)

        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void PlayGame()
        {
            ChooseHowManyPlayers();
            CompareGestures(Player player1, Player player2);
            //if score is less than 2
            //go back to choosegesture under player
            //else say who won
        }


        public void ChooseHowManyPlayers()
        {
            Console.WriteLine("How many players?");
            string UserInputHowMany = Console.ReadLine();
                if(UserInputHowMany == "1")
                {
                Human player1 = new Human();
                Computer player2 = new Computer();
                }
                else if(UserInputHowMany == "2")
                {
                Human player1 = new Human();
                Human player2 = new Human();
                }
        }

       public void CompareGestures(Player player1, Player player2)
        {
            if (player1.gesture == "rock" && player2.gesture =="scissors")
            {
                Console.WriteLine("Rock crushes scissors! Round point goes to {0}", player1.name);
                player1.score++;
            }
            if (player1.gesture ==
        }

    }
}
