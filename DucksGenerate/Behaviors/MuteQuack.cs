using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            string howToquack = "Silence";
            return howToquack;
        }
    }
}
