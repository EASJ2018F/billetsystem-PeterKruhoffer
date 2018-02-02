﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Bil bil = new Bil("1234567");
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void KørertøjTest()
        {
            //Arange
            Bil bil = new Bil("1234567");
            //Act
            string kørertøj = bil.TypeAfKørertøj();
            //Assert
            Assert.AreEqual("Bil", kørertøj);
        }

        [TestMethod]
        public void NummerpladeExceptionTest()
        {
            //Arange
            Bil bil = new Bil("12345678");
            //Act
            
            //Assert
            Assert.IsTrue(bil.Nummerplade.Length > 7);
        }
    }
}