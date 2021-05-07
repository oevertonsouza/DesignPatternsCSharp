using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;

namespace DucksGenerate.Ducks.UsDucks
{
    public class UsRubberDuck : ModelDuck {

        string origin = DuckInfo.DuckOrigin.US;

        IQuackBehavior quackBehavior = new Squeack();
        IFlyBehavior flyBehavior = new FlyNoWings();

        public override string display()
        {
            string display = "Rubber Duck " + origin;
            return display;
        }

        public override string performSwim()
        {
            return base.performSwim() + " " + origin;
        }

        public override string performFly()
        {
            return flyBehavior.fly() + " " + origin;
        }

        public override string performQuack()
        {
            return quackBehavior.quack() + " " + origin;
        }
   
    }
}
