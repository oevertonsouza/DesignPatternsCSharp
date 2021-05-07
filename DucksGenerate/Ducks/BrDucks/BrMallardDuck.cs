﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Ducks.BrDucks
{
    public class BrMallardDuck : ModelDuck
    {
        string origin = DuckInfo.DuckOrigin.BR;

        public override string display()
        {
            string display = "Mallard Duck " + origin;
            return display;
        }

        public override string performSwim()
        {
            return base.performSwim() + " " + origin;
        }

        public override string performQuack()
        {
            return base.performQuack() + " " + origin;
        }

        public override string performFly()
        {
            return base.performFly() + " " + origin;
        }

    }
}