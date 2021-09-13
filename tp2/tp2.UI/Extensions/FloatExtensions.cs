using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.UI.Extensions
{
    public static class FloatExtensions
    {
        public static float DividirPorCero(this float dividendo)
        {
            int divisor = 0;
            return divisor == 0? throw new DivideByZeroException() : dividendo / divisor;
        }
    }
}
