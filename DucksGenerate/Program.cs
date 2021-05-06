using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DucksGeneate.Ducks;


namespace DucksGeneate
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
            ducks = ducksGenerator.GetAllDucks();

            foreach (var duck in ducks)
            {
                duck.Show();
            }

            Console.WriteLine("Final of Strategy!");
        }


    }
}
