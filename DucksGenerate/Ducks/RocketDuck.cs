using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Behaviors;

namespace Strategy.Ducks
{
    class RocketDuck : ModelDuck
    {
        IFlyBehavior flyBehavior = new FlyRocket();

        public override void display()
        {
            Console.WriteLine("Rocket Duck");
            return;
        }

        public override void performFly()
        {
            flyBehavior.fly();
            return;
        }

    }
}
