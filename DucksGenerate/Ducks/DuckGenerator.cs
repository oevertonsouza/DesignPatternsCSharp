using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Factory;
using DucksGenerate.Ducks.Iterator;

namespace DucksGenerate.Ducks
{
    public class DuckGenerator 
    {
        public DuckIterator GetCountryByCountry(string country)
        {
            /*
             * Icing on the cake 
             * Like Uncle Bob said once about Swich Cases on the Code Clean Book
             * Its can appear only once and should by hidden of the process
             * Its can increase exponentially - If you can to use other way, make it
             */
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
            return new DuckIterator(ducks);
        }



    }

}
