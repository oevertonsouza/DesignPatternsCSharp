using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGeneate.Ducks
{
    public class MallardDuck : ModelDuck
    {
        public override string display()
        {
            string display = "Mallard Duck";
            Console.WriteLine(display);
            return display;
        }

    }
}
