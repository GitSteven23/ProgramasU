﻿using System;

namespace ProgramasCorteII
{
    public class MenuProgramas
    {
        static void Main(string[] args)
        {
            int opcion;
            string continuar;
            do
            {
                Console.Clear();
                Console.WriteLine("UNIVERSIDAD ECCI - ARQUITECTURA DE SOFTWARE");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("==============================================");
                Console.WriteLine("Menú de opciones Corte II: ");
                Console.WriteLine("1. Operaciones matemáticas");
                Console.WriteLine("2. Funciones matemáticas");
                Console.WriteLine("3. Respuestas correctas/incorrectas");
                Console.WriteLine("4. CONMEBOL Libertadores");
                Console.WriteLine("5. Promedio producción empleado");
                Console.WriteLine("6. Copia de seguridad");
                Console.WriteLine("7. Sumatoria positivos/negativos");
                Console.WriteLine("8. Muestreo peso personas");
                Console.WriteLine("9. Matriz de calificaciones");
                Console.WriteLine("10. Nomina empleados");
                Console.WriteLine("==============================================");
                Console.WriteLine("Seleccione número de programa: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        OperacionesMatematicas operaciones = new OperacionesMatematicas();
                        operaciones.OperacionesBasicas();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;
                }
                Console.WriteLine("Desea realizar otra operación: S/N");
                continuar = Console.ReadLine();
            }
            while (continuar == "s" || continuar == "S");
        }
    }
}
