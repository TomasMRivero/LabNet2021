using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2.Logica;

namespace tp2.Entities
{
    public class Logic:LogicAbstract
    {
        public Logic() : base("Logic")
        {
        }

        public override void ArrojarExcepcion()
        {
            throw new Exception();
        }
    }
}
