using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void MCPrisTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCKøretøjTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string kørertøj = mc.Kørertøj();
            //Assert
            Assert.AreEqual("MC", kørertøj);
        }
    }
}
