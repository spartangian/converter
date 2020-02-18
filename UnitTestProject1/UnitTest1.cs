using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicToRomanNumerals;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_I_To_1()
        {
            Assert.AreEqual(1, new TestClass().Convert("I"));
        }

        [TestMethod]
        public void Convert_II_To_2()
        {
            Assert.AreEqual(2, new TestClass().Convert("II"));
        }

        [TestMethod]
        public void Convert_III_To_3()
        {
            Assert.AreEqual(3, new TestClass().Convert("III"));
        }

        [TestMethod]
        public void Convert_V_To_5()
        {
            Assert.AreEqual(5, new TestClass().Convert("V"));
        }

        [TestMethod]
        public void Convert_IV_To_4()
        {
            Assert.AreEqual(4, new TestClass().Convert("IV"));
        }

        [TestMethod]
        public void Convert_VI_To_6()
        {
            Assert.AreEqual(6, new TestClass().Convert("VI"));
        }

        [TestMethod]
        public void Convert_CXL_To_140()
        {
            Assert.AreEqual(140, new TestClass().Convert("CXL"));
        }

        [TestMethod]
        public void Convert_MXL_To_1040()
        {
            Assert.AreEqual(1040, new TestClass().Convert("MXL"));
        }

        [TestMethod]
        public void Convert_MCMXIV_To_1914()
        {
            Assert.AreEqual(1914, new TestClass().Convert("MCMXIV"));
        }
    }
}
