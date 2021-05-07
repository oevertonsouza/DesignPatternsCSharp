using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;
using DucksGenerate.Factory;
using DucksGenerate.Ducks.UsDucks;

namespace DucksGenerate.Factory 
{
    public class UsDuckFactory : IDuckFactory
    {
        public ModelDuck createMallardDuck()
        {
            return new UsMallardDuck();
        }

        public ModelDuck createRocketDuck()
        {
            return new UsRocketDuck();
        }

        public ModelDuck createRubberDuck()
        {
            return new UsRubberDuck();
        }
    }
}
