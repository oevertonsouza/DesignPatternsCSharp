using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;

namespace DucksGenerate.Ducks.Command
{
    public class RubberShowCommand : ICommand 
    {
        private ModelDuck modelDuck;

        public RubberShowCommand(ModelDuck modelDuck)
        {
            this.modelDuck = modelDuck;
        }

        /* Icing on the cake
        *  He's embarrassed of not know fly 
        */
        public void Execute() { 
            Console.WriteLine(modelDuck.Display());
            Console.WriteLine(modelDuck.PerformQuack());
            Console.WriteLine(modelDuck.PerformSwim());
            //Not to show! =)
            //Console.WriteLine(modelDuck.performFly());
            Console.WriteLine("...");
            Console.WriteLine("----");
        }
    }
}
