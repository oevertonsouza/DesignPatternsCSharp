
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DucksGenerate.Ducks.Command
{
    /* Cherry Cake
     * Is this a Command interface 
     * All Command classes implements a execute method
     * This created a flexive way for execute difence behaviors with the same way
     */
    public interface ICommand
    {
        void Execute();
    }
}
