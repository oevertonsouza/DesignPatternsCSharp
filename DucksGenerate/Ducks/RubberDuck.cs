using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Behaviors;

namespace Strategy.Ducks
{
    class RubberDuck : ModelDuck {

        IQuackBehavior quackBehavior = new Squeack();
        IFlyBehavior flyBehavior = new FlyNoWings();

        public override void display()
        {
            Console.WriteLine("Rubber Duck");
            return;
        }

        public override void performFly()
        {
            flyBehavior.fly();
            return;
        }

        public override void performQuack()
        {
            quackBehavior.quack();
            return;
        }

    
    }
}
