using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class Squeack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Squeack";
            Console.WriteLine(howToquack);
            return howToquack;
        }
    }
}
