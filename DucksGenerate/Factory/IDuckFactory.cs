using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;

namespace DucksGenerate.Factory
{
    public interface IDuckFactory
    {
        ModelDuck createMallardDuck();
        ModelDuck createRocketDuck();
        ModelDuck createRubberDuck();
    }
}
