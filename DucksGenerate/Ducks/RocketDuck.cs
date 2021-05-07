using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;

namespace DucksGenerate.Ducks
{
    public class RocketDuck : ModelDuck
    {
        IFlyBehavior flyBehavior = new FlyRocket();

        public override string display()
        {
            string display = "Rocket Duck";
            return display;
        }

        public override string performFly()
        {
            return this.flyBehavior.fly();
        }

    }
}
