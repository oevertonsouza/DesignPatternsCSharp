using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Behaviors
{
    public class Squeack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Squeack";
            return howToquack;
        }
    }
}
