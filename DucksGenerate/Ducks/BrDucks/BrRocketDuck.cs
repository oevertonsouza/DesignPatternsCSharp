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

        public override string Display()
        {
            string display = "Rocket Duck " + origin;
            return display;
        }

        public override string PerformSwim()
        {
            return base.PerformSwim() + " " + origin;
        }

        public override string PerformFly()
        {
            return this.flyBehavior.fly() + " " + origin;
        }

        public override string PerformQuack()
        {
            return base.PerformQuack() + " " + origin;
        }

    }
}
