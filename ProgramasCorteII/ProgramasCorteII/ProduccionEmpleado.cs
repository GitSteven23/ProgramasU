using System;
using System.Linq;

namespace ProgramasCorteII
{
    public class ProduccionEmpleado
    {
        public void ProduccionEmpleado1()
        {

            int[] dias = new int[7];
            int total;
            string continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("PROGRAMAS CORTE II - C#");
                Console.WriteLine("Produccion Empleado");
                Console.WriteLine("==============================================");

                for (int i = 1; i < dias.Length; i++)
                {
                    Console.WriteLine("Digite la productivdad del dia :" + i);
                    dias[i] = int.Parse(Console.ReadLine());

                }

                total = (dias.Sum() / 6);

                if (total < 100)
                {
                    Console.WriteLine("La productivdad del trabajador es de : " + total);
                    Console.WriteLine("El trabajador no merece una bonificacion");

                }
                else
                {
                    Console.WriteLine("La productivdad del trabajador es de : " + total);
                    Console.WriteLine("El trabajador merece una bonificacion");
                }

                Console.WriteLine("Desea realizar otro cálculo: S/N");
                continuar = Console.ReadLine();
            }
            while (continuar == "s" || continuar == "S");
        }
    }
}