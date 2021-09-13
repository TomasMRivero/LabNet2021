using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Logica
{
    public abstract class LogicAbstract
    {
        public string Nombre { get; private set; }
        public LogicAbstract(string nombre)
        {
            Nombre = nombre;
        }
        public abstract void ArrojarExcepcion();
    }
}
