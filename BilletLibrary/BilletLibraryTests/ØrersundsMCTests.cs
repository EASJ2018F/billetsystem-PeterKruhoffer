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
    public class ØrersundsMCTests
    {
        [TestMethod()]
        public void ØrersundMCPrisTest()
        {
            //Arange
            ØrersundsMC ØMc = new ØrersundsMC("1234567",DateTime.Today);
            //Act
            int pris = ØMc.Pris(210);
            //Assert
            Assert.AreEqual(210, pris);
        }

        [TestMethod()]
        public void ØrersundMCTypeAfKørertøjTest()
        {
            //Arange
            ØrersundsMC ØMc = new ØrersundsMC("1234567", DateTime.Today);
            //Act
            string typeAfKørertøj = ØMc.TypeAfKørertøj();
            //Assert
            Assert.AreEqual("Ørersund MC", typeAfKørertøj);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Max 7 tegn i nummerplade")]
        public void ØresundMcNummerpladeExceptionTest()
        {
            //Arange
           ØrersundsMC Ømc = new ØrersundsMC("12345678",DateTime.Today);
        }
    }
}