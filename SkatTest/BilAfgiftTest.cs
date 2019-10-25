using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skat;
using System;

namespace SkatTest
{
    [TestClass]
    public class BilAfgiftTest
    {
        [TestMethod]
        public void AlmBilAfgiftTest()
        {
            //Arrange
            double pris = 100000;
            double expectedvalue = 85000;

            //Act

            double actuel = Afgift.BilAfgift(pris);



            //Assert
            Assert.AreEqual(expectedvalue, actuel);
        }

        [TestMethod]
        public void AlmBilAfgiftOverTest()
        {
            //Arrange
            double pris = 230000;
            double expectedvalue = 215000;


            //Act

            double actuel = Afgift.BilAfgift(pris);

            //Assert
            Assert.AreEqual(expectedvalue, actuel);
        }

        [TestMethod]
        public void ElbilAfgiftTest()
        {
            //Arrange
            double pris = 250000;

            double expectedvalue = 49000;

            //Act
            double actual = Afgift.ElBilAfgift(pris);

            //Assert
            Assert.AreEqual(expectedvalue, actual);
        }
    }
}
