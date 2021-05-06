using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Behaviors;

namespace DucksGeneate.Ducks
{
    public class RocketDuck : ModelDuck
    {
        IFlyBehavior flyBehavior = new FlyRocket();

        public override string display()
        {
            string display = "Rocket Duck";
            Console.WriteLine(display);
            return display;
        }

        public override string performFly()
        {
            return this.flyBehavior.fly();
        }

    }
}
