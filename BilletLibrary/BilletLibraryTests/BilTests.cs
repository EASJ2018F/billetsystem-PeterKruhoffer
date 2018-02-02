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
    public class BilTests
    {
        [TestMethod()]
        public void BilPrisTest()
        {
            //Arange
            Bil bil = new Bil("0123456", DateTime.Today);
            //Act
            int pris = bil.Pris(240);
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void KørertøjTest()
        {
            //Arange
            Bil bil = new Bil("0123456", DateTime.Today);
            //Act
            string kørertøj = bil.TypeAfKørertøj();
            //Assert
            Assert.AreEqual("Bil", kørertøj);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Max 7 tegn i nummerplade")]
        public void NummerpladeExceptionTest()
        {
            //Arange
            Bil bil = new Bil("12345678", DateTime.Today);
        }

        [TestMethod]
        public void HarBrobizzHverdagBilTest()
        {
            //Arange
            Bil bil = new Bil("1234567",DateTime.Today);
            bil.HarBrobizz = true;
            //Act
            int pris = bil.Pris(240);
            //Assert
            Assert.AreEqual(230,pris);
        }

        [TestMethod]
        public void WeekendHarBrobizzRabatTest()
        {
            //Arange
            DateTime dato = new DateTime(2018,02,03);
            Bil bil = new Bil("1234567",dato);
            bil.HarBrobizz = true;
            //Act
            int pris = bil.Pris(240);
            //Assert
            Assert.AreEqual(190,pris);
        }

        [TestMethod]
        public void WeekendUdenBrobizzRabatTest()
        {
            //Arange
            DateTime dato = new DateTime(2018, 02, 04);
            Bil bil = new Bil("1234567", dato);
            bil.HarBrobizz = false;
            //Act
            int pris = bil.Pris(240);
            //Assert
            Assert.AreEqual(200, pris);
        }
    }
}