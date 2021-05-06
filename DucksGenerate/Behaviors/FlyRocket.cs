using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Behaviors
{
    public class FlyRocket : IFlyBehavior
    {
        string IFlyBehavior.fly()
        {
            string howToFLy = "Go To Stars!!!";
            Console.WriteLine(howToFLy );
            return howToFLy; 
        }
    }
}
