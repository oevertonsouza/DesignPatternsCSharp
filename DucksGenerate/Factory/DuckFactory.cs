using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Ducks;

namespace DucksGeneate.Factory
{
    public class DuckFactory
    {
        public MallardDuck createMallardDuck(){
            return new MallardDuck();
        }

        public RocketDuck createRocketDuck()
        {
            return new RocketDuck();
        }

        public RubberDuck createRubberDuck() {
            return new RubberDuck();
        }
    }
}
