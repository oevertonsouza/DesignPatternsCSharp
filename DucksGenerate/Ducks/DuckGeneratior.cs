using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Factory;

namespace Strategy.Ducks
{
    class DuckGeneratior
    {
        private int amount;
        Random range = new Random();
        DuckFactory duckFactory = new DuckFactory();

        public void setAmount(int amount)
        {
            this.amount = amount;
        }
         
        public List<ModelDuck> Generate()
        {
            List<ModelDuck> ducks = new List<ModelDuck>();
            for (int i = 0; i < amount; i++)
            {
                ducks.Add(GetSomeDuck());
            }
            return ducks;
        }

        private ModelDuck GetSomeDuck()
        {
            switch (range.Next(0, 4))
            {
                case 1:
                    return duckFactory.createRocketDuck();
                case 2:
                    return duckFactory.createRubberDuck();
            }
            return new MallardDuck();
        }

    }

}
