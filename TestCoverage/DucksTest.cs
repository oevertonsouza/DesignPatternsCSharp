using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DucksGenerate.Ducks;

namespace CoverageTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class DucksTest
    {
        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_None()
        {
           List<ModelDuck> ducks;
           DuckGenerator duckGenerator = new DuckGenerator();
           ducks = duckGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.NONE);

           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performFly(), "Can Fly");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performQuack(), "Quack");
           
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performFly(), "Can't Fly");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performQuack(), "Squeack");
           
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performFly(), "Go To Stars!!!");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performQuack(), "Quack");

        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_US()
        {
            List<ModelDuck> ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);

        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_BR()
        {
            List<ModelDuck> ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].performQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].performQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].performQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

        }

    }
}
