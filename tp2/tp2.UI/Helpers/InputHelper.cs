using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.UI.Helpers
{
    class InputHelper
    {
        public static float ValidarFloat(string input)
        {
            float num;
            while (!float.TryParse(input, out num))
            {
                Console.WriteLine("Tenés que ingresar un número real: ");
                input = Console.ReadLine();
            }
            return num;
        }
        public static int ValidarInt(string input)
        {
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine("Tenés que ingresar un número entero: ");
                input = Console.ReadLine();
            }
            return num;
        }
    }
}
