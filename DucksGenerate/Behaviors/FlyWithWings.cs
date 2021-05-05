using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Behaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public  void fly()
        {
            Console.WriteLine("Can Fly");
        }
    }
}
