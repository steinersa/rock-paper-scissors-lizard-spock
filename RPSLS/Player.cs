﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (Has A)
        public string name;
        public string gesture;
       
        //constructor
        public Player()
        {
           
        }

        //member methods (Can Do)
        public abstract string EnterName();
        public abstract string ChooseGesture();

    }
}