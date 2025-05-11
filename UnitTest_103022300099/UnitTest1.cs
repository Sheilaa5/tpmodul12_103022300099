using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_103022300099; 

namespace UnitTest_103022300099
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CariTandaBilangan_Negatif()
        {
            int input = -5;
            string expected = "Negatif";
            string actual = Form1.CariTandaBilangan(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CariTandaBilangan_Positif()
        {
            int input = 10;
            string expected = "Positif";
            string actual = Form1.CariTandaBilangan(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CariTandaBilangan_Nol()
        {
            int input = 0;
            string expected = "Nol";
            string actual = Form1.CariTandaBilangan(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

