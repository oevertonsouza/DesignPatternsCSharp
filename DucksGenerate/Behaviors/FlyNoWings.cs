using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class FlyNoWings : IFlyBehavior
    {
        public string fly()
        {
            string howToFly = "Can't Fly";
            Console.WriteLine(howToFly);
            return howToFly;
        }
    }
}
