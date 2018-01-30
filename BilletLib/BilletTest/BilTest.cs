using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilPrisTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void BilKørerTøjTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string kørertøj = bil.Kørertøj();
            //Assert
            Assert.AreEqual("Bil", kørertøj);
        }
    }
}
