using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Factory;

namespace DucksGeneate.Ducks
{


    public class DuckGenerator
    {
        public enum DuckTypes
        {
            ROCKETDUCK = 0,
            RUBBERDUCK = 1,
            MALLARDDUCK = 2
        }


        private int amount;
        Random range = new Random();
        DuckFactory duckFactory = new DuckFactory();

        public void setAmount(int amount)
        {
            this.amount = amount;
        }
         
        public List<ModelDuck> GetAllDucks()
        {
            List<ModelDuck> ducks = new List<ModelDuck>();
            ducks.Add(duckFactory.createRocketDuck());
            ducks.Add(duckFactory.createRubberDuck());
            ducks.Add(duckFactory.createMallardDuck());
            return ducks;
        }

    }

}
