using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadorBisiesto
{
    [TestClass]
    public class StringCalculatorTest
    {
       public StringCalculator _stringCalculator;

        [TestMethod]
        public void CalculateZeroNumbersTest()
        {
            _stringCalculator = new StringCalculator("");
            Assert.AreEqual(0, _stringCalculator.GetValue());
        }

        [TestMethod]
        public void CalculateOneNumberTest()
        {
            _stringCalculator = new StringCalculator("1");
            Assert.AreEqual(1, _stringCalculator.GetValue());
        }

        [TestMethod]
        public void CalculateTwoNumberTest()
        {
            _stringCalculator = new StringCalculator("1,2");
            Assert.AreEqual(3, _stringCalculator.GetValue());
        }

        [TestMethod]
        public void CalculateMoreThanTwoNumberTest()
        {
            _stringCalculator = new StringCalculator("1,2,3,4,5,6");
            Assert.AreEqual(21, _stringCalculator.GetValue());
        }

        [TestMethod]
        public void AddNewLinesBetewnComasTest()
        {
            _stringCalculator = new StringCalculator("1\n2,3,4,5,6");
            Assert.AreEqual(21, _stringCalculator.GetValue());
        }

        [TestMethod, ExpectedException(typeof(System.FormatException))]
        public void AddInvalitFormatTest()
        {
            _stringCalculator = new StringCalculator("1,\n");
            _stringCalculator.GetValue();
        }

        [TestMethod]
        public void SupportDelimiterTest()
        {
            _stringCalculator = new StringCalculator("//;\n1;2");
            Assert.AreEqual(3, _stringCalculator.GetValue());
        }

        [TestMethod, ExpectedException(typeof(System.Exception))]
        public void NotSupportNevativesTest()
        {
            _stringCalculator = new StringCalculator("//;\n1;-2");
            Assert.AreEqual(3, _stringCalculator.GetValue());
        }

        [TestMethod]
        public void NumbersBigerThan1000ShouldbyIgnoredTest()
        {
            _stringCalculator = new StringCalculator("//;\n2;1001");
            Assert.AreEqual(2, _stringCalculator.GetValue());
        }
    }


}
