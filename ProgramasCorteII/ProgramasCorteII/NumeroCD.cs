using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    class NumeroCD
    {
        public void CDNecesarios()
        {
            #region Variables
            int capDisco;
            double numCD;
            string continuar;
            double convertir;
            int capCD = 700;
            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("Cálculo de CD'S para copia de seguridad");
                Console.WriteLine("==============================================");

                Console.WriteLine("Menú de opciones Cálculo de CD'S: ");
                Console.WriteLine("Ingrese la capacidad del disco al que le quiere hacer copia");
                capDisco = int.Parse(Console.ReadLine());
                convertir = capDisco * 1024;
                numCD = Math.Round(convertir / capCD);
                Console.WriteLine("La suma total es: " + (numCD));

                Console.WriteLine("Desea realizar otro cálculo: S/N");
                continuar = Console.ReadLine();
            }
            while (continuar == "s" || continuar == "S");
        }
    }
}
