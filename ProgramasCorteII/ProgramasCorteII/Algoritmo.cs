using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
   public  class Algoritmo
    {
        public void numerospositivos()
        {
            
            int num;

            
            Console.WriteLine("Saber si el numero es Positivo, Negativo,");

            
            Console.Write("Ingrese un Numero: ");


            num = Int32.Parse(Console.ReadLine());

            
            if (num == 0)
            {
                Console.Write("Su Numero es 0.");
            }
            else if (num >= 1)
            {
                Console.Write("Su numero '" + num + "' es Positivo.");
            }
            else if (num <= -1)
            {
                Console.Write("'tSu numero '" + num + "' es Negativo.");
            }

          
        }


    }
}
