using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Behaviors;

namespace DucksGeneate.Ducks
{
    public class RubberDuck : ModelDuck {

        IQuackBehavior quackBehavior = new Squeack();
        IFlyBehavior flyBehavior = new FlyNoWings();

        public override string display()
        {
            string display = "Rubber Duck";
            Console.WriteLine(display);
            return display;
        }

        public override string performFly()
        {
            return flyBehavior.fly(); ;
        }

        public override string performQuack()
        {
            return quackBehavior.quack();
        }

    
    }
}
