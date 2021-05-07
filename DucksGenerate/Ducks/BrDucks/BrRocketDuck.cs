using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;

namespace DucksGenerate.Ducks.BrDucks
{
    public class BrRocketDuck : ModelDuck
    {
        string origin = "BR";

        IFlyBehavior flyBehavior = new FlyRocket();

        public override string display()
        {
            string display = "Rocket Duck " + origin;
            return display;
        }

        public override string performSwim()
        {
            return base.performSwim() + " " + origin;
        }

        public override string performFly()
        {
            return this.flyBehavior.fly() + " " + origin;
        }

        public override string performQuack()
        {
            return base.performQuack() + " " + origin;
        }

    }
}
