using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadorBisiesto
{
    [TestClass]
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void PutFizzOn3Test()
        {
            
            Assert.AreEqual("Fizz", _fizzBuzz.PaserFizzBuzz(9));
        }


        [TestMethod]
        public void PutBuzzOn5Test()
        {

            Assert.AreEqual("Buzz", _fizzBuzz.PaserFizzBuzz(10));
        }


        [TestMethod]
        public void PutFizzBuzzOn3or5Test()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.PaserFizzBuzz(150));
        }

        [TestMethod]
        public void NumberNotDivisibleBy3Neithsr5Test()
        {
            Assert.AreEqual("4",_fizzBuzz.PaserFizzBuzz(4));
        }

        [TestMethod]
        public void DoTheWholeThing()
        {
            var AllOfIt = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
            Assert.AreEqual(AllOfIt,_fizzBuzz.DoWholeThing(15));
        }
    }
}
