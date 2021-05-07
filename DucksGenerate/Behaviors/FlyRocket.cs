using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Behaviors
{
    public class FlyRocket : IFlyBehavior
    {
        string IFlyBehavior.fly()
        {
            string howToFLy = "Go To Stars!!!";
            return howToFLy; 
        }
    }
}
