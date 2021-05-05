using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Behaviors;

namespace Strategy.Ducks
{
    abstract class ModelDuck 
    {
        IQuackBehavior quackBehavior = new Quack();
        IFlyBehavior flyBehavior = new FlyWithWings();

        public virtual void display()
        {
            Console.WriteLine("Duck");
            return;
        }

        public virtual void performQuack()
        {
            this.quackBehavior.quack();
            return;
        }

        public virtual void performSwim()
        {
            Console.WriteLine("Can Swim");
            return;
        }

        public virtual void performFly()
        {
            this.flyBehavior.fly();
            return;
        }

        public void setFlyBehavior(IFlyBehavior fb) {
            this.flyBehavior  = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }

        public void Show() {
            display();
            performQuack();
            performSwim();
            performFly();
            Console.WriteLine("----");
        }
    
    }
}
