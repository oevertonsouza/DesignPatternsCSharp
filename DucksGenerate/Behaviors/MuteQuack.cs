using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Silence";
            Console.WriteLine(howToquack);
            return howToquack;
        }
    }
}
