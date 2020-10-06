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
            double num3;
            

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
                Console.WriteLine("5.  TRUCATE");
                Console.WriteLine("6.  SENO");
                Console.WriteLine("7.  COSENO");
                Console.WriteLine("8.  POTENCIA");
                Console.WriteLine("9.  TRUCATE");
                Console.WriteLine("10.  TRUCATE");

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

                        Console.WriteLine("Ingresen el primer numero ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresen el primer numero ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El numero minimo es: " + Math.Min(num1, num2));

                        break;

                    case 3:

                        Console.WriteLine("Ingresen el  numero ");
                        num3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El numero  es: " +  Math.Round( num3 ));


                        break;

                    case 4:

                        Console.WriteLine("Ingresen un numero  : ");
                        num1 = int.Parse(Console.ReadLine());


                        Console.WriteLine("La raiz cuadrada es :" + Math.Sqrt(num1));

                        break;



                    case 5:

                        Console.WriteLine("Ingresen un numero  : ");
                        num3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado es:" + Math.Truncate(num3));

                        break;

                    case 6:
                        Console.WriteLine("Ingresen un numero  : ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado es:" + Math.Sin(num1 *Math.PI/180));

                        break;

                    case 7:
                        Console.WriteLine("Ingresen un numero  : ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado es:" + Math.Cos(num1*Math.PI / 180));
                        break;

                    case 8:
                        Console.WriteLine("Ingresen un numero  : ");
                        num3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado es:" + Math.Pow(num3,5));

                        break;

                    case 9:


                        break;


                    case 10:


                        break;

                }
                Console.WriteLine("Desea realizar otra operación: S/N");
                continuar = Console.ReadLine();


            } while (true);
           


        }

    }
}
