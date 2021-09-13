using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.UI.Extensions
{
    public static class FloatExtensions
    {
        public static float Dividir(this float dividendo)
        {
            int divisor = 0;
            return Dividir(dividendo, divisor);
        }
        public static float Dividir(this float dividendo, float divisor)
        {
            return divisor == 0 ? throw new DivideByZeroException() : dividendo / divisor;
        }
    }
}
