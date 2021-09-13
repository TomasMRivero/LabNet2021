using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tp2.Exceptions;

namespace tp2.UI.Helpers
{
    class InputHelper
    {
        public static float ValidarFloat(string input)
        {
            float num;
            return float.TryParse(input, out num) ? num : throw new WrongInputException();
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
