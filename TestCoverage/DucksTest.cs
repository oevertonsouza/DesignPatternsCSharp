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

           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformFly(), "Can Fly");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformQuack(), "Quack");
           
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformFly(), "Can't Fly");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformQuack(), "Squeack");
           
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformFly(), "Go To Stars!!!");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformSwim(), "Can Swim");
           Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformQuack(), "Quack");
        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_US()
        {
            List<ModelDuck> ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.US);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);

        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_BR()
        {
            List<ModelDuck> ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetCountryByCountry(DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.MALLARDDUCK].PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.RUBBERDUCK].PerformQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.BR);

            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(ducks[DuckInfo.DuckTypes.ROCKETDUCK].PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

        }

    }
}
