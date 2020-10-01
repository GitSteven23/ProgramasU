using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class OperacionesMatematicas
    {
        public void OperacionesBasicas()
        
        {
            #region Variables
            int opcion;
            string continuar;
            int num1, num2;
            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("Operaciones Matemáticas");
                Console.WriteLine("==============================================");

                Console.WriteLine("Menú de opciones Operaciones matemáticas: ");
                Console.WriteLine("Escoja la operación que desea realizar ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma total es: " + (num1+num2));
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La resta total es: " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La multiplicación total es: " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La división total es: " + (num1 / num2));
                        break;
                }
                Console.WriteLine("Desea realizar otra operación: S/N");
                continuar = Console.ReadLine();
            } 
            while (continuar == "s" || continuar == "S");
            
        }
    }
}
