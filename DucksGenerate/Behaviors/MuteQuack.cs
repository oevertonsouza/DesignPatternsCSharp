using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Behaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
