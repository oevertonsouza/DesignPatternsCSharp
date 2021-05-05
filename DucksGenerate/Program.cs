using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Ducks;


namespace Strategy
{
    /*
     * 
     * This is a prject based from book head first (Design Patterns) 
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

            DuckGeneratior GeradorDePatos = new DuckGeneratior();
            GeradorDePatos.setAmount(20);
            ducks = GeradorDePatos.Generate();

            foreach (var duck in ducks)
            {
                duck.Show();
            }

            Console.WriteLine("Fim of Strategy!");
        }


    }
}
