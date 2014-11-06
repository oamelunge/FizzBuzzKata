using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadorBisiesto
{
    [TestClass]
    public class Class1
    {


        public bool LlamarACalculadorBisiestos(int anio)
        {
            CalculadorBisiestos _calculadorBisiestos = new CalculadorBisiestos(anio);
            return _calculadorBisiestos.value();
        }

        [TestMethod]
        public void TestAnioBisiestoTipico()
        {

            Assert.IsTrue(LlamarACalculadorBisiestos(1996));
        }

        [TestMethod]
        public void TestElanio2001esNoBisiesto()
        {
            Assert.IsFalse(LlamarACalculadorBisiestos(2001));
        }

        [TestMethod]
        public void TestElAnio1900NoBisiesto()
        {

            Assert.IsFalse(LlamarACalculadorBisiestos(1900));
        }

        [TestMethod]

        public void TestAnioBisiestoNoTipico()
        {
            Assert.IsTrue(LlamarACalculadorBisiestos(2000));
        }
    }
}
