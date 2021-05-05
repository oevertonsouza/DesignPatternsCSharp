using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Ducks
{
    class MallardDuck : ModelDuck
    {
        public override void display()
        {
            Console.WriteLine("Mallard Duck");
            return;
        }

    }
}
