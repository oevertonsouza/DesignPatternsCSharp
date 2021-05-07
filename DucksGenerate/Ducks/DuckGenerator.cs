using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Factory;

namespace DucksGenerate.Ducks
{
    public class DuckGenerator 
    {
        private int amount;
        Random range = new Random();
        
        
        public List<ModelDuck> GetCountryByCountry(string country)
        {
            List<ModelDuck> ducks = new List<ModelDuck>();
            IDuckFactory duckFactory;
            switch (country)
            {
                case DuckInfo.DuckOrigin.US:
                    duckFactory = new UsDuckFactory();
                    break;
                case DuckInfo.DuckOrigin.BR:
                    duckFactory = new BrDuckFactory();
                    break;
                default:
                    duckFactory = new DuckFactory();
                    break;
            }
            ducks.Insert(DuckInfo.DuckTypes.MALLARDDUCK, duckFactory.createMallardDuck());
            ducks.Insert(DuckInfo.DuckTypes.RUBBERDUCK, duckFactory.createRubberDuck());
            ducks.Insert(DuckInfo.DuckTypes.ROCKETDUCK, duckFactory.createRocketDuck());
            return ducks;
        }



    }

}
