using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DucksGeneate.Ducks;

namespace CoverageTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class DucksTest
    {
        [TestMethod]
        public void Test_Duck_Performance()
        {
            List<ModelDuck> ducks;
            DuckGenerator geradorDePatos = new DuckGenerator();
            ducks = geradorDePatos.GetAllDucks();
            
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.MALLARDDUCK].performFly(), "Can Fly");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.MALLARDDUCK].performSwim(), "Can Swim");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.MALLARDDUCK].performQuack(), "Quack");

            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.RUBBERDUCK].performFly(), "Can't Fly");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.RUBBERDUCK].performSwim(), "Can Swim");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.RUBBERDUCK].performQuack(), "Squeack");

            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.ROCKETDUCK].performFly(), "Go To Stars!!!");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.ROCKETDUCK].performSwim(), "Can Swim");
            Assert.AreEqual(ducks[(int)DuckGenerator.DuckTypes.ROCKETDUCK].performQuack(), "Quack");

        }
    }
}
