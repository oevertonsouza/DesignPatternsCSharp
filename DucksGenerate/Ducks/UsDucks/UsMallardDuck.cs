using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;
using DucksGenerate.Ducks.Command;

namespace DucksGenerate.Ducks.UsDucks
{
    public class UsMallardDuck : ModelDuck
    {
        string origin = DuckInfo.DuckOrigin.US;

        public override string Display()
        {
            string display = "Mallard Duck " + origin;
            return display;
        }

        public override string PerformSwim()
        {
            return base.PerformSwim() + " " + origin;
        }

        public override string PerformQuack()
        {
            return base.PerformQuack() + " " + origin;
        }

        public override string PerformFly()
        {
            return base.PerformFly() + " " + origin;
        }
        
    }
}
