using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Behaviors;

namespace DucksGeneate.Ducks
{
    public abstract class ModelDuck 
    {
        IQuackBehavior quackBehavior = new Quack();
        IFlyBehavior flyBehavior = new FlyWithWings();

        public virtual string display()
        {
            string display = "Duck";
            Console.WriteLine("Duck");
            return display;
        }

        public virtual string performQuack()
        {
            return this.quackBehavior.quack(); ;
        }

        public virtual string performSwim()
        {
            string swim = "Can Swim";
            Console.WriteLine("Can Swim");
            return swim;
        }

        public virtual string performFly()
        {
            return this.flyBehavior.fly();
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


        public ModelDuck()
        {
            // TODO: Complete member initialization
        }
    }
}
