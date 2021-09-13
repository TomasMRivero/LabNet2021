using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp2.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.UI.Extensions.Tests
{
    [TestClass()]
    public class FloatExtensionsTests
    {
        [TestMethod()]
        public void Dividir()
        {
            float dividendo = 10;
            float divisor = 5;
            float resultadoEsperado = 2;

            float actual = dividendo.Dividir(divisor);

            Assert.AreEqual(resultadoEsperado, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_DividirPorCeroPorDefecto_ArrojaExcepcion()
        {
            float dividendo = 10;

            dividendo.Dividir();
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_DividirPorCeroConParametro_ArrojaExcepcion()
        {
            float dividendo = 10;
            float divisor = 0;

            dividendo.Dividir(divisor);
        }
    }
}