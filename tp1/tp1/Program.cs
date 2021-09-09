using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxTaxis = 5;
            int maxOmnibus = 5;

            List<TransportePublico> taxis = new List<TransportePublico>();
            List<TransportePublico> omnibuses = new List<TransportePublico>();


            for (int i = 1;i <= maxTaxis; i++)
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros para taxi {i}: ");
                taxis.Add(new Taxi(IngresarNumero()));
            }

            Console.ReadLine();

            for (int i = 1; i <= maxOmnibus; i++)
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros para omnibus {i}: ");
                omnibuses.Add(new Omnibus(IngresarNumero()));
            }

            Console.ReadLine();

            MostrarLista(taxis, "Taxi");
            Console.WriteLine();
            MostrarLista(omnibuses, "Omnibus");

            Console.ReadLine();

        }
        private static void MostrarLista(List<TransportePublico> lista, string tipoDeTransporte)
        {
            int i = 1;
            foreach (var e in lista)
            {
                Console.WriteLine($"{tipoDeTransporte} {i++}: {e.Pasajeros}");
            }
        }
        private static int IngresarNumero()
        {
            string num;
            int pasajeros;

            num = Console.ReadLine();

            while (!int.TryParse(num, out pasajeros) || pasajeros < 0)
            {
                Console.WriteLine("Tenés que ingresar un número entero positivo: ");
                num = Console.ReadLine();
            }
            return pasajeros;
        }
    }
}
