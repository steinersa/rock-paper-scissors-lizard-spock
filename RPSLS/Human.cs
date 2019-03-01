using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human:Player
    {

        //constructor
        public Human()
        {
            this.name = EnterName();
        }

        //member methods (Can Do)
        public override string EnterName()
        {
            Console.WriteLine("Please enter your name:");
            string UserInputName = Console.ReadLine();
            return UserInputName;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Please enter the gesture you'd like to throw (rock, paper, scissors, lizard, or spock):");
            gesture = Console.ReadLine();
        }
    }
}
