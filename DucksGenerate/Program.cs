using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;
using DucksGenerate.Factory;
using DucksGenerate.Ducks.Iterator;

namespace DucksGenerate
{
    /*
     * This is a prject based from books and community examples
     * In this project I created a Strategy pattern 
     * with a litle Factor for created randow ducks
     * and show Ducks on Console
     */
    class Program
    {
        static void Main(string[] args)
        {
            DuckIterator ducks, ducksFromBR, ducksFromUS;
            DuckGenerator ducksGenerator = new DuckGenerator();

            ducks = ducksGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.NONE);
            ducksFromBR = ducksGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.BR);
            ducksFromUS = ducksGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.US);

            DucksShowList(ducks);
            DucksShowList(ducksFromBR);
            DucksShowList(ducksFromUS);
            
            Console.WriteLine("Final of Project!");
        }

        public static void DucksShowList(DuckIterator ducks)
        {
            /* 
             * Icing on the cake 
             * Using Duck Iterator
             */
            while (ducks.HasNext())
	        {
                ModelDuck duck = (ModelDuck)ducks.GetNext();
                duck.Show();
	        }
        }


    }
}
