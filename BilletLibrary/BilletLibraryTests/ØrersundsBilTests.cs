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
    public class ØrersundsBilTests
    {
        [TestMethod()]
        public void ØrersundsBilPrisTest()
        {
            //Arange
            ØrersundsBil Øbil = new ØrersundsBil("1234567",DateTime.Today);
            //Act
            int pris = Øbil.Pris(410);
            //Assert
            Assert.AreEqual(410,pris);
        }

        [TestMethod()]
        public void TypeAfKørertøjTest()
        {
            //Arange
            ØrersundsBil Øbil = new ØrersundsBil("1234567", DateTime.Today);
            //Act
            string typeØbil = Øbil.TypeAfKørertøj();
            //Assert
            Assert.AreEqual("Ørersund Bil", typeØbil);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Max 7 tegn i nummerplade")]
        public void ØrersundBilNummerpladeExceptionTest()
        {
            //Arange
            ØrersundsBil Øbil = new ØrersundsBil("12345678",DateTime.Today);
        }
    }
}