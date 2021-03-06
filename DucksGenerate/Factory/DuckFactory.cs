using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Factory;
using DucksGenerate.Ducks;

namespace DucksGenerate.Factory
{
    public class DuckFactory : IDuckFactory
    {
        public ModelDuck createMallardDuck()
        {
            return new MallardDuck();
        }

        public ModelDuck createRocketDuck()
        {
            return new RocketDuck();
        }

        public ModelDuck createRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
