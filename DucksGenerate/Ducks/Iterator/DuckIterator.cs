using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Ducks.Iterator
{
    /* 
     * Icing on the cake 
     * Concrete class iterator for my ducks
     * original implementation from head first book (page 244) brasilian version 2° Edition
     * This class get next object of list and vefify if exists next object, 
     * becaming possible to use wile expression
     * 
     * Example:
     *   while (ducks.HasNext())
	 *   {
     *      ModelDuck duck = (ModelDuck)ducks.GetNext();
     *      duck.Show();
	 *   }
     *  
     * With this the client of the object not need know what is run,
     * you can modify of the list or your source and everything remains ok
     * 
     */
    public class DuckIterator : IIterator
    {
        private int position = 0;
        private List<ModelDuck> duckList;

        public DuckIterator(List<ModelDuck> duckList) 
        {
            this.duckList = duckList;
        }

        public bool HasNext()
        {
            bool hasNext;
            if (position >= duckList.Count || duckList[position] == null)
            {
                hasNext = false;
            }
            else
            {
                hasNext = true;            
            }
            return hasNext;
        }

        public Object GetNext()
        {
            ModelDuck duck = duckList[position];
            position = position + 1;
            return duck;

        }
    }
}
