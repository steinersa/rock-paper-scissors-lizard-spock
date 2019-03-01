using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (Has A)
        public string name;
        public string gesture;
        public int score;
       
        //constructor
        public Player()
        {
           
        }

        //member methods (Can Do)
        public abstract void EnterName();
        public abstract void ChooseGesture();

    }
}
