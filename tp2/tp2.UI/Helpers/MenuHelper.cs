using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tp2.UI.Extensions;
using tp2.Entities;
using tp2.Exceptions;

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

                int ej = InputHelper.ValidarInt(Console.ReadLine());

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
                case 2:
                    Punto2();
                    return false;
                case 3:
                    Punto3();
                    return false;
                case 4:
                    Punto4();
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

                float num = InputHelper.ValidarFloat(Console.ReadLine());

                Console.WriteLine($"Numero dividido por cero: {num.Dividir()}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (WrongInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Operación finalizada");
            }
        }
        private static void Punto2()
        {
            try
            {
                Console.WriteLine("Ingrese el dividendo (numero real): ");
                float dividendo = InputHelper.ValidarFloat(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor (numero real): ");
                float divisor = InputHelper.ValidarFloat(Console.ReadLine());

                Console.WriteLine($"{dividendo} / {divisor} = {dividendo.Dividir(divisor)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Solo Chuck Norris divide por cero!");
            }
            catch (WrongInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Operación finalizada");
            }
        }
        private static void Punto3()
        {
            var logic = new Logic();
            logic.ArrojarExcepcion();
        }
        private static void Punto4()
        {
            var logic = new Logic();
            logic.ArrojarExcepcionCustom();
        }
    }
}
