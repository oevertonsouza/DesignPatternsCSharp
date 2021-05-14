using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;

namespace DucksGenerate.Ducks.Command
{
    public class DuckShowCommand : ICommand
    {
        private ModelDuck modelDuck;

        public DuckShowCommand(ModelDuck modelDuck)
        {
            this.modelDuck = modelDuck;
        }

        /* Cherry Cake
        * I can to create a diferent class Command
        * for have a many way of to show the behaviors
        * See the RubberShowCommand
        * He's embarrassed of not know fly 
        */
        public void Execute() { 
            Console.WriteLine(modelDuck.Display());
            Console.WriteLine(modelDuck.PerformQuack());
            Console.WriteLine(modelDuck.PerformSwim());
            Console.WriteLine(modelDuck.PerformFly());
            Console.WriteLine("----");
        }
    }
}
