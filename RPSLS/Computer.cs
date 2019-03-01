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
            this.name = EnterName();
        }

        //member methods (Can Do)
        public override string EnterName()
        {
            return "Computer";
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