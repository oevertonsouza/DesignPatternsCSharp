using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            string howToFly = "Can Fly";
            Console.WriteLine(howToFly);
            return howToFly;
        }
    }
}
