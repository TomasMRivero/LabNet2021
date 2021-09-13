using System;
using tp2.UI.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using tp2.Exceptions;

namespace tp2.UITests4.Extensions
{
    [TestClass()]
    public class InputHelperTests
    {
        [TestMethod()]
        public void ValidarFloat()
        {
            string input = "2,2";
            float esperado = 2.2F;

            float actual = InputHelper.ValidarFloat(input);

            Assert.AreEqual(esperado, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(WrongInputException))]
        public void ValidatFloat_IngresarCaracter_ArrojaExcepcion()
        {
            string input = "a";

            InputHelper.ValidarFloat(input);
        }

        [TestMethod()]
        [ExpectedException(typeof(WrongInputException))]
        public void ValidatFloat_NoIngresarNada_ArrojaExcepcion()
        {
            string input = "";

            InputHelper.ValidarFloat(input);
        }

    }
}
