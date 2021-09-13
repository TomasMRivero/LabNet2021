using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tp2.Exceptions;

namespace tp2.Entities.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void ArrojarExcepcion_ArrojaExcepcion()
        {
            var obj = new Logic();

            obj.ArrojarExcepcion();
        }
        [TestMethod()]
        [ExpectedException(typeof(BrokenMatrixException))]
        public void ArrojarExcepcionCustom_ArrojaExcepcion()
        {
            var obj = new Logic();

            obj.ArrojarExcepcionCustom();
        }
    }
}