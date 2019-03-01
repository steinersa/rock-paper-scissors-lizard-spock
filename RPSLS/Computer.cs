using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer:Player
    {


        //constructor
        public Computer()
        {
        
        }

        //member methods (Can Do)
        public override void EnterName()
        {
            name = "Computer";
        }

        public override void ChooseGesture()
        {
            List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            gesture = gestures[RandomNumber(0, 5)];
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}