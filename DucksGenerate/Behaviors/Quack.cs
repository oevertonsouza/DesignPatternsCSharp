using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Quack";
            Console.WriteLine(howToquack);
            return howToquack;
        }

    }
}
