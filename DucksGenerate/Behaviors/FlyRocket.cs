using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Behaviors
{
    class FlyRocket : IFlyBehavior
    {

        void IFlyBehavior.fly()
        {
            Console.WriteLine("Go To Stars!!!");
        }
    }
}
