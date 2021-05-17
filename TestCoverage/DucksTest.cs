using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DucksGenerate.Ducks;
using DucksGenerate.Ducks.Iterator;

namespace CoverageTest
{
    /// <summary>
    /// Teste Duck classes and yous behaviors using Iterator
    /// </summary>
    [TestClass]
    public class DucksTest
    {
        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_None()
        {
            DuckIterator ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.NONE);

            ModelDuck mallardDuck = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(mallardDuck.PerformFly(), "Can Fly");
            Assert.AreEqual(mallardDuck.PerformSwim(), "Can Swim");
            Assert.AreEqual(mallardDuck.PerformQuack(), "Quack");

            ModelDuck rubberDuck = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(rubberDuck.PerformFly(), "Can't Fly");
            Assert.AreEqual(rubberDuck.PerformSwim(), "Can Swim");
            Assert.AreEqual(rubberDuck.PerformQuack(), "Squeack");

            ModelDuck rocketDuck = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(rocketDuck.PerformFly(), "Go To Stars!!!");
            Assert.AreEqual(rocketDuck.PerformSwim(), "Can Swim");
            Assert.AreEqual(rocketDuck.PerformQuack(), "Quack");
        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_BR()
        {
            DuckIterator ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.BR);

            ModelDuck mallardDuckBR = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(mallardDuckBR.PerformFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(mallardDuckBR.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(mallardDuckBR.PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

            ModelDuck rubberDuckBR = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(rubberDuckBR.PerformFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(rubberDuckBR.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(rubberDuckBR.PerformQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.BR);

            ModelDuck rocketDuckBR = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(rocketDuckBR.PerformFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(rocketDuckBR.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.BR);
            Assert.AreEqual(rocketDuckBR.PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.BR);

        }

        [TestMethod]
        public void Test_Duck_Performance_By_Counrty_US()
        {
            DuckIterator ducks;
            DuckGenerator duckGenerator = new DuckGenerator();
            ducks = duckGenerator.GetDucksByCountry(DuckInfo.DuckOrigin.US);

            ModelDuck mallardDuckUS = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(mallardDuckUS.PerformFly(), "Can Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(mallardDuckUS.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(mallardDuckUS.PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);

            ModelDuck rubberDuckUS = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(rubberDuckUS.PerformFly(), "Can't Fly" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(rubberDuckUS.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(rubberDuckUS.PerformQuack(), "Squeack" + " " + DuckInfo.DuckOrigin.US);

            ModelDuck ricketDuckUS = (ModelDuck)ducks.GetNext();
            Assert.AreEqual(ricketDuckUS.PerformFly(), "Go To Stars!!!" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ricketDuckUS.PerformSwim(), "Can Swim" + " " + DuckInfo.DuckOrigin.US);
            Assert.AreEqual(ricketDuckUS.PerformQuack(), "Quack" + " " + DuckInfo.DuckOrigin.US);
        }
    }
}