using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;
using DucksGenerate.Ducks.Command;

namespace DucksGenerate.Ducks
{
    public class RubberDuck : ModelDuck {

        IQuackBehavior quackBehavior = new Squeack();
        IFlyBehavior flyBehavior = new FlyNoWings();


        public RubberDuck()
        {
            /* Cherry Cake
             * We can see that we have many RubberDucks 
             * from diference countries, and each one of them
             * can obtais difence behaviors, 
             * in these example they will haves the same.
            */
            base.showCommand = new RubberShowCommand(this);
        }

        public override string Display()
        {
            string display = "Rubber Duck";
            return display;
        }

        public override string PerformFly()
        {
            return flyBehavior.fly(); ;
        }

        public override string PerformQuack()
        {
            return quackBehavior.quack();
        }

    
    }
}
