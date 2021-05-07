using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;

namespace DucksGenerate.Ducks
{
    public abstract class ModelDuck  
    {

        /* Cherry Cake
         * Use composition
         * Created set methods for change behavior in runtime
         */
        IQuackBehavior quackBehavior = new Quack();
        IFlyBehavior flyBehavior = new FlyWithWings();

        public virtual string display()
        {
            string display = "Duck";
            return display;
        }

        public virtual string performQuack()
        {
            return this.quackBehavior.quack(); ;
        }

        public virtual string performSwim()
        {
            string swim = "Can Swim";
            return swim;
        }

        public virtual string performFly()
        {
            return this.flyBehavior.fly();
        }

        /* Cherry Cake
         * Use set methods  for change behavior in runtime
         * A duck can won new skills in your journey
         */
        public void setFlyBehavior(IFlyBehavior fb) {
            this.flyBehavior  = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }

        public void Show() {
            Console.WriteLine(display());
            Console.WriteLine(performQuack());
            Console.WriteLine(performSwim());
            Console.WriteLine(performFly());
            Console.WriteLine("----");
        }

    }
}
