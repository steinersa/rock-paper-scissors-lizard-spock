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
            CompareGestures();
            //increment score by 1
            //if score is less than 2
            //else say who won
            //go back to choosegesture under player
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

       public void CompareGestures()
        {
            if (player1.gesture == "rock" && player2.gesture =="scissors")
            {
                Console.WriteLine("{0}'s rock crushes {0}'s scissors! Round point goes to {0}", name, name);
                //increment score
            }
            if (player1.)
        }

    }
}
