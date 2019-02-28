using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer:Player
    {

        //variavke

        //constructor
        public Computer()
        {
            this.name = EnterName();
            this.gesture = ChooseGesture();
        }

        //member methods (Can Do)
        public override string EnterName()
        {
            return "Computer";
        }

        public override string ChooseGesture()
        {
            List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            string gesture = gestures[RandomNumber(0, 5)];
            return gesture;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}