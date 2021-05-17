using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Ducks.Iterator
{
    /* 
     * Icing on the cake 
     * Is this a iterator interface
     * Use this to run any type of list
     */
    interface IIterator
    {
        bool HasNext();
        Object GetNext();
    }
}
