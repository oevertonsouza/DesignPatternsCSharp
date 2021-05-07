using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            string howToFly = "Can Fly";
            return howToFly;
        }
    }
}
