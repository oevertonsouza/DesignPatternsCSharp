using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Behaviors
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }

    }
}
