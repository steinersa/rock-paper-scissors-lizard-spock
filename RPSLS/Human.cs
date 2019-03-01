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
         
        }

        //member methods (Can Do)
        public override void EnterName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("{0}, please enter the gesture you'd like to throw (rock, paper, scissors, lizard, or spock).", this.name);
            gesture = Console.ReadLine();
        }
    }
}
