using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tp2.Entities;
using tp2.UI.Helpers;

namespace tp2.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MenuHelper.MostrarMenu();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Excepcion ej3: {ex.Message}");
            }
        }
    }
}
