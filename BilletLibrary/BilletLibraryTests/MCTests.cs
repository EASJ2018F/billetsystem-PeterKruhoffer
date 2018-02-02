using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arange
            MC mc = new MC("0123456");
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KørertøjTest()
        {
            //Arange
            MC mc = new MC("0123456");
            //Act
            string kørertøj = mc.TypeAfKørertøj();
            //Assert
            Assert.AreEqual("MC", kørertøj);
        }
    }
}