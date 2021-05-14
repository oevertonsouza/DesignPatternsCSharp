using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;

namespace DucksGenerate.Ducks.UsDucks
{
    public class UsRocketDuck : ModelDuck
    {
        string origin = DuckInfo.DuckOrigin.US;

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
