using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using dalzate2f1;

namespace dalzate2fUnitTests.cs
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01AInputGE100()
        {
            Assert.AreEqual("0.20", Calculations.Calc01("100.0"));
        }
        [TestMethod]
        public void Test01AInputLT100()
        {
            Assert.AreEqual("0.00", Calculations.Calc01("99.99"));
        }
        [TestMethod]
        public void Test02AInputGE100()
        {
            Assert.AreEqual("Bulk rate: 0.20", Calculations.Calc02("100.00"));
        }
        [TestMethod]
        public void Test02AInputLT100()
        {
            Assert.AreEqual("Standard rate: ", Calculations.Calc02("99.99"));
        }
        [TestMethod]
        public void Test03AInputGE100()
        {
            Assert.AreEqual("0.20", Calculations.Calc03("100.00"));
        }
        [TestMethod]
        public void Test03AInputLT100()
        {
            Assert.AreEqual("0.10", Calculations.Calc03("99.99"));
        }
        [TestMethod]
        public void Test04AInputLT100()
        {
            Assert.AreEqual("0.10", Calculations.Calc04("99.99"));
        }
        [TestMethod]
        public void Test04AInputGE100LT200A()
        {
            Assert.AreEqual("0.20", Calculations.Calc04("100.00"));
        }
        [TestMethod]
        public void Test04AInputGE100LT200B()
        {
            Assert.AreEqual("0.20", Calculations.Calc04("199.99"));
        }
        [TestMethod]
        public void Test04AInputGE200LT300A()
        {
            Assert.AreEqual("0.30", Calculations.Calc04("200.00"));
        }
        [TestMethod]
        public void Test04AInputGE200LT300B()
        {
            Assert.AreEqual("0.30", Calculations.Calc04("299.99"));
        }
        [TestMethod]
        public void Test04AInputGE300()
        {
            Assert.AreEqual("0.40", Calculations.Calc04("300.00"));
        }
        [TestMethod]
        public void Test05AInputLT100()
        {
            Assert.AreEqual("0.10", Calculations.Calc05("99.99"));
        }
        [TestMethod]
        public void Test05AInputGE100LT200A()
        {
            Assert.AreEqual("0.20", Calculations.Calc05("100.00"));
        }
        [TestMethod]
        public void Test05AInputGE100LT200B()
        {
            Assert.AreEqual("0.20", Calculations.Calc05("199.99"));
        }
        [TestMethod]
        public void Test05AInputGE200LT300A()
        {
            Assert.AreEqual("0.30", Calculations.Calc05("200.00"));
        }
        [TestMethod]
        public void Test05AInputGE200LT300B()
        {
            Assert.AreEqual("0.30", Calculations.Calc05("299.99"));
        }
        [TestMethod]
        public void Test05AInputGE300()
        {
            Assert.AreEqual("0.40", Calculations.Calc05("300.00"));
        }
        [TestMethod]
        public void Test06AInputLT100()
        {
            Assert.AreEqual("0.10", Calculations.Calc06("99.99", "R"));
        }
        [TestMethod]
        public void Test06AInputGE100LT200A()
        {
            Assert.AreEqual("0.20", Calculations.Calc06("100.00", "R"));
        }
        [TestMethod]
        public void Test06BInputNotR()
        {
            Assert.AreEqual("0.40", Calculations.Calc06("100.00", "Z"));
        }
        [TestMethod]
        public void Test07AInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc07(""));
        }
        [TestMethod]
        public void Test07AInput100()
        {
            Assert.AreEqual("20,000.00", Calculations.Calc07("100.00"));
        }
        [TestMethod]
        public void Test08AInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc08("", "2.00"));
        }
        [TestMethod]
        public void Test08BInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc08("25.00", ""));
        }
        [TestMethod]
        public void Test08TotalLT50()
        {
            Assert.AreEqual("54.98", Calculations.Calc08("24.99", "2.00"));
        }
        [TestMethod]
        public void Test08TotalGE50()
        {
            Assert.AreEqual("50.00", Calculations.Calc08("25.00", "2.00"));
        }
        [TestMethod]
        public void Test09AInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc09("", "11000"));
        }
        [TestMethod]
        public void Test09BInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc09("10000", ""));
        }
        [TestMethod]
        public void Test09A_GT_BInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc09("11000", "10000"));
        }
        [TestMethod]
        public void Test09ValidDiff1000()
        {
            Assert.AreEqual("100.00", Calculations.Calc09("10000", "11000"));
        }
        [TestMethod]
        public void Test10AInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc10("", "2"));
        }
        [TestMethod]
        public void Test10BInputEmpty()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc10("2", ""));
        }
        [TestMethod]
        public void Test10InputA0()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc10("0", "1"));
        }
        [TestMethod]
        public void Test10InputB0()
        {
            Assert.AreEqual("Invalid input", Calculations.Calc10("1", "0"));
        }
        [TestMethod]
        public void Test10Valid4Div2()
        {
            Assert.AreEqual("2.00", Calculations.Calc10("4", "2"));
        }
        [TestMethod]
        public void Test10Valid2Div4()
        {
            Assert.AreEqual("2.00", Calculations.Calc10("2", "4"));
        }
        [TestMethod]
        public void Test10Valid4Div4()
        {
            Assert.AreEqual("1.00", Calculations.Calc10("4", "4"));
        }
    }
}