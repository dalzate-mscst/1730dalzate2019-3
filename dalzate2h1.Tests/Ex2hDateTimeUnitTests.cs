using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dalzate2h1.Tests
{
    [TestClass]
    public class Ex2hDateTimeUnitTests
    {
        [TestMethod]
        public void DateCalc06_YearNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc06("", "01", "01"));
        }
        [TestMethod]
        public void DateCalc06_MonthNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc06("2000", "", "01"));
        }
        [TestMethod]
        public void DateCalc06_DayNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc06("2000", "01", ""));
        }
        [TestMethod]
        public void DateCalc06_DateArgRangeExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc06("2000", "13", "01"));
        }
        [TestMethod]
        public void DateCalc06_ValidDateCtor()
        {
            Assert.AreEqual("1/1/2000", Ex2hCalculations.DateCalc06("2000", "1", "1"));
        }
        [TestMethod]
        public void DateCalc07_DateParseExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc07("aaa"));
        }
        [TestMethod]
        public void DateCalc07_ValidDateParse()
        {
            Assert.AreEqual("1/1/2000", Ex2hCalculations.DateCalc07("1/1/2000"));
        }
        [TestMethod]
        public void DateCalc08_DateTryParseErr()
        {
            Assert.AreEqual("1/1/0001", Ex2hCalculations.DateCalc08("aaa"));
        }
        [TestMethod]
        public void DateCalc08_ValidDateTryParse()
        {
            Assert.AreEqual("1/1/2000", Ex2hCalculations.DateCalc08("1/1/2000"));
        }
        [TestMethod]
        public void DateCalc09_DateParseExceptA()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc09("aaa", "1/1/2000"));
        }
        public void DateCalc09_DateParseExceptB()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc09("1/1/2000", "aaa"));
        }
        [TestMethod]
        public void DateCalc09_ValidDates()
        {
            Assert.AreEqual("31 days", Ex2hCalculations.DateCalc09("2/1/2000", "1/1/2000"));
        }
        [TestMethod]
        public void DateCalc10_DateParseExceptA()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc10("aaa", "1/1/2000"));
        }
        public void DateCalc10_DateParseExceptB()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.DateCalc10("1/1/2000", "aaa"));
        }
        [TestMethod]
        public void DateCalc10_31DaysPastDue()
        {
            Assert.AreEqual("31 days past due", Ex2hCalculations.DateCalc10("2/1/2000", "1/1/2000"));
        }
        [TestMethod]
        public void DateCalc10_OnTime()
        {
            Assert.AreEqual("On time", Ex2hCalculations.DateCalc10("1/1/2000", "1/1/2000"));
        }
        [TestMethod]
        public void StringCalc01_InvalidInput()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.StringCalc01("  "));
        }
        [TestMethod]
        public void StringCalc01_ReplaceChar0()
        {
            Assert.AreEqual("crab", Ex2hCalculations.StringCalc01(" aab"));
        }
        [TestMethod]
        public void StringCalc02_InvalidInput()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.StringCalc02(" a "));
        }
        [TestMethod]
        public void StringCalc02_ReplaceChar1()
        {
            Assert.AreEqual("aritb", Ex2hCalculations.StringCalc02(" aab"));
        }
        [TestMethod]
        public void StringCalc03_InvalidInput()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.StringCalc03(" aaaaa "));
        }
        [TestMethod]
        public void StringCalc03_SubstrUpper()
        {
            Assert.AreEqual("AAAA", Ex2hCalculations.StringCalc03(" aaaaaa "));
        }
        [TestMethod]
        public void StringCalc04_PadEmpty()
        {
            Assert.AreEqual("**********", Ex2hCalculations.StringCalc04("  "));
        }
        [TestMethod]
        public void StringCalc04_Pad()
        {
            Assert.AreEqual("******aaaa", Ex2hCalculations.StringCalc04(" aaaa "));
        }
        [TestMethod]
        public void StringCalc05_Replace()
        {
            Assert.AreEqual("1234", Ex2hCalculations.StringCalc05(" 1(2)3-4"));
        }
        [TestMethod]
        public void StringCalc06_ReplaceInsert7()
        {
            Assert.AreEqual("123.4567", Ex2hCalculations.StringCalc06(" 1(2)3-4567 "));
        }
        [TestMethod]
        public void StringCalc06_ReplaceInsert10()
        {
            Assert.AreEqual("012.345.6789", Ex2hCalculations.StringCalc06(" 01(2)3-4567 89 "));
        }
        [TestMethod]
        public void StringCalc07_NotFound()
        {
            Assert.AreEqual("Not found", Ex2hCalculations.StringCalc07(" pIoNer "));
        }
        [TestMethod]
        public void StringCalc07_Found()
        {
            Assert.AreEqual("Found", Ex2hCalculations.StringCalc07(" pIoNeEr "));
        }
        [TestMethod]
        public void StringCalc08_Invalid()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.StringCalc08("aaaa aaaa"));
        }
        [TestMethod]
        public void StringCalc08_CommaFound()
        {
            Assert.AreEqual("aaaa", Ex2hCalculations.StringCalc08("aaaa, aaaa"));
        }
        [TestMethod]
        public void StringCalc09_Invalid()
        {
            Assert.AreEqual("Invalid input", Ex2hCalculations.StringCalc09("  aaaaaaaa  "));
        }
        [TestMethod]
        public void StringCalc09_SpaceFound()
        {
            Assert.AreEqual("11111-1111", Ex2hCalculations.StringCalc09(" aaaa 11111-1111 "));
        }
        [TestMethod]
        public void StringCalc10_SBAppend()
        {
            Assert.AreEqual("aaa, bbb, ccc", Ex2hCalculations.StringCalc10("aaa", "bbb", "ccc"));
        }
    }
}
