using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Behaviors;
using DucksGenerate.Ducks.Command;

namespace DucksGenerate.Ducks
{
    public abstract class ModelDuck  
    {
        /* Icing on the cake
         * Use composition
         * Created set methods for change behavior in runtime
         */
        IQuackBehavior quackBehavior = new Quack();
        IFlyBehavior flyBehavior = new FlyWithWings();
        public ICommand showCommand  {get; set;}

        public ModelDuck() {
            /* Icing on the cake
             * The command is on costructor 
             * but can to by changed in run time
             */
            this.showCommand = new DuckShowCommand(this);
        }

        public virtual string Display()
        {
            string display = "Duck";
            return display;
        }

        public virtual string PerformQuack()
        {
            return this.quackBehavior.quack(); ;
        }

        public virtual string PerformSwim()
        {
            string swim = "Can Swim";
            return swim;
        }

        public virtual string PerformFly()
        {
            return this.flyBehavior.fly();
        }

        /* Icing on the cake
         * Use set methods for change behavior in runtime
         * A duck can won new skills in your journey
         */
        public void SetFlyBehavior(IFlyBehavior fb) {
            this.flyBehavior  = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }

        public void Show() {
            showCommand.Execute();
        }

    }
}
