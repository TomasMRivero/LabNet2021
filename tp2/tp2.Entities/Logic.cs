using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2.Logica;
using tp2.Exceptions;

namespace tp2.Entities
{
    public class Logic: LogicAbstract, ILogic
    {
        public Logic() : base("Logic")
        {
        }

        public override void ArrojarExcepcion()
        {
            throw new Exception();
        }

        public void ArrojarExcepcionCustom()
        {
            throw new BrokenMatrixException();
        }
    }
}
