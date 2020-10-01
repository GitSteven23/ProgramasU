using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{

   
    public class FuncionesMatematicas
    {
        public void FuncionesBasicas()

        {
            int opcion;
            string continuar;
            int num1, num2;

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("Funciones Matemáticas");
                Console.WriteLine("==============================================");


                Console.Clear();
                Console.WriteLine("1.  MAXIMO");
                Console.WriteLine("2.  MINIMO ");
                Console.WriteLine("3.  REDONDEO: ");
                Console.WriteLine("4.  RAIZ");
                Console.WriteLine("4.  TRUCATE");

                opcion = int.Parse(Console.ReadLine());



                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresen el primer numero ");
                             num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresen el primer numero ");
                             num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El numero maximo es: "+ Math.Max(num1,num2));

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                   
                }
                Console.WriteLine("Desea realizar otra operación: S/N");
                continuar = Console.ReadLine();


            } while (true);
           


        }

    }
}
