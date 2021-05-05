using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Behaviors
{
    class FlyNoWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}
