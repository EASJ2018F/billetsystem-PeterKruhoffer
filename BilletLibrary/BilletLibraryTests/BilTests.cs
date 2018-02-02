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
            int pris = bil.Pris();
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
        public void HarBrobizzBilTest()
        {
            //Arange
            Bil bil = new Bil("1234567",DateTime.Today);
            bil.HarBrobizz = true;
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void WeekendHarBrobizzRabatTest()
        {
            //Arange
            DateTime dato = new DateTime(2017,02,03);
            Bil bil = new Bil("1234567",dato);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }
    }
}