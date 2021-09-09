using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }

        public TransportePublico(int pasajeros)
        {
            Pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
