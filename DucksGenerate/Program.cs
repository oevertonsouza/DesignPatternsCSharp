using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGenerate.Ducks;
using DucksGenerate.Factory;


namespace DucksGenerate
{
    /*
     * 
     * This is a prject based from books and community examples
     * In this project I created a Strategy pattern 
     * with a litle Factor for created randow ducks
     * and show Ducks on Console
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<ModelDuck> ducks;
            DuckGenerator ducksGenerator = new DuckGenerator();

            ducks = ducksGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.BR);

            foreach (var duck in ducks)
            {
                duck.Show();
            }

            ducks = ducksGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.US);

            foreach (var duck in ducks)
            {
                duck.Show();
            }

            ducks = ducksGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.NONE);

            foreach (var duck in ducks)
            {
                duck.Show();
            }
            
            Console.WriteLine("Final of Strategy!");
        }


    }
}
