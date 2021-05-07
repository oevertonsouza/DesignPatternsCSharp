using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;
using DucksGenerate.Factory;
using DucksGenerate.Ducks.BrDucks;

namespace DucksGenerate.Factory
{
    public class BrDuckFactory : IDuckFactory 
    {
        ModelDuck IDuckFactory.createMallardDuck()
        {
            return new BrMallardDuck();
        }

        ModelDuck IDuckFactory.createRocketDuck()
        {
            return new BrRocketDuck();
        }

        ModelDuck IDuckFactory.createRubberDuck()
        {
            return new BrRubberDuck();
        }
    }
}
