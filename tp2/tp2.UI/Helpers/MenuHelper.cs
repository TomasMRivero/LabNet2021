using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tp2.UI.Extensions;

namespace tp2.UI.Helpers
{
    public static class MenuHelper
    {
        public static void MostrarMenu()
        {
            bool finalizar;
            do
            {
                Console.WriteLine("Ingrese un número correspondiente a un ejercicio (0 para salir): ");

                string input = Console.ReadLine();
                int ej;

                while (!int.TryParse(input, out ej))
                {
                    Console.WriteLine("Tenés que ingresar un número entero: ");
                    input = Console.ReadLine();
                }

                finalizar = MenuSwitch(ej);
            } while (!finalizar);
            
        }
        private static bool MenuSwitch(int ej)
        {
            switch (ej)
            {
                case 0:
                    return true;
                case 1:
                    Punto1();
                    return false;
                default:
                    Console.WriteLine("Ejercicio invalido");
                    return false;
            }
        }
        private static void Punto1()
        {
            try
            {
                Console.WriteLine("Ingrese un número real para dividir por cero: ");

                string input = Console.ReadLine();
                float num;

                while (!float.TryParse(input, out num))
                {
                    Console.WriteLine("Tenés que ingresar un número real: ");
                    input = Console.ReadLine();
                }

                num.DividirPorCero();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Operación finalizada");
            }
        }
    }
}
