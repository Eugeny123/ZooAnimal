﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAml()
        {
            Console.WriteLine("My name is " + Name+" .");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + "said this: "+ message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
