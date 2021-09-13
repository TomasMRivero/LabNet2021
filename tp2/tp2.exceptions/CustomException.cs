using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Exceptions
{
    public class BrokenMatrixException : Exception
    {
        public BrokenMatrixException() : base("Error en la matrix.")
        {
        }

    }
    public class WrongInputException : Exception
    {
        public WrongInputException() : base("Seguro Ingreso una letra o no ingreso nada!")
        {
        }
    }
}
