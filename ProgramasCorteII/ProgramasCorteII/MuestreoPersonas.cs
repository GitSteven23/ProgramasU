using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class MuestreoPersonas
    {
        public void MuestraPersonas()
        {
            #region VARIABLES

            string continuar;
            int[] personas = new int[10];
            int peso, edad;

            double promedioNiños = 0;
            double promedioJovenes = 0;
            double promedioAdultos = 0;
            double promedioAncianos = 0;

            double calculoNiños = 0;
            double calculoJovenes = 0;
            double calculoAdultos = 0;
            double calculoAncianos = 0;

            double totalPromedioNiños = 0;
            double totalPromedioJovenes = 0;
            double totalPromedioAdultos = 0;
            double totalPromedioAncianos = 0;

            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("Muestreo personas");
                Console.WriteLine("==============================================");

                for (int i = 1; i < personas.Length; i++)
                {
                    Console.WriteLine("***Persona " + i + "***");
                    Console.WriteLine("Digite su edad: ");
                    edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite su peso en Kg: ");
                    peso = int.Parse(Console.ReadLine());

                    //Niños
                    if (edad >= 0 && edad <= 13)
                    {
                        promedioNiños = promedioNiños + peso;
                        calculoNiños = calculoNiños + 1;
                    }
                    //Jovenes
                    else if (edad >= 14 && edad <= 30)
                    {
                        promedioJovenes = promedioJovenes + peso;
                        calculoJovenes = calculoJovenes + 1;
                    }
                    //Adultos
                    else if (edad >= 31 && edad <= 60)
                    {
                        promedioAdultos = promedioAdultos + peso;
                        calculoAdultos = calculoAdultos + 1;
                    }
                    //Ancianos
                    else if (edad > 60)
                    {
                        promedioAncianos = promedioAncianos + peso;
                        calculoAncianos = calculoAncianos + 1;
                    }
                }

                //Calculo de promedios
                totalPromedioNiños = promedioNiños / calculoNiños;
                totalPromedioJovenes = promedioJovenes / calculoJovenes;
                totalPromedioAdultos = promedioAdultos / calculoAdultos;
                totalPromedioAncianos = promedioAncianos / calculoAncianos;

                //Impresión de datos
                Console.WriteLine("==================================================");
                Console.WriteLine("***TOTALES***");
                Console.WriteLine("Promedio peso niños: " + Math.Round(totalPromedioNiños, 2) + " kg");
                Console.WriteLine("Promedio peso jóvenes: " + Math.Round(totalPromedioJovenes, 2) + " kg");
                Console.WriteLine("Promedio peso adultos: " + Math.Round(totalPromedioAdultos, 2) + " kg");
                Console.WriteLine("Promedio peso ancianos: " + Math.Round(totalPromedioAncianos, 2) + " kg");
                Console.WriteLine("==================================================");

                Console.WriteLine("Desea realizar otro cálculo: S/N");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S");
        }
    }
}
