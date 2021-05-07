using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Quack";
            return howToquack;
        }

    }
}
