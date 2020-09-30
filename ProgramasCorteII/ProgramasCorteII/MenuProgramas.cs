using System;

namespace ProgramasCorteII
{
    class MenuProgramas
    {
        static void Main(string[] args)
        {
            int opcion;
            string continuar;
            do
            {
                Console.Clear();
                Console.WriteLine("UNIVERSIDAD ECCI");
                Console.WriteLine("MENU DE PROGRAMAS - VISUAL C SHARP");
                Console.WriteLine("Nomina de Empleados");
                Console.WriteLine("2. Sistema de Notas - Universidad Ecci");
                Console.WriteLine("3. Operaciones Matematicas");
                Console.WriteLine("4. Evaluacion y Analisis de Respuestas");
                Console.WriteLine("5. Uefa Champions League");
                Console.WriteLine("6. Promedio de Produccion de un Empleado");
                Console.WriteLine("7. Copia de Seguridad");
                Console.WriteLine("8. Caracteristicas de Una Serie de Numeros");
                Console.WriteLine("9. Estadistica de Pesos");
                Console.WriteLine("10. Funciones Matematicas");
                Console.WriteLine("Seleccione el numero del programa a ejecutar");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:                       
                        break;

                    case 2:                       
                        break;

                    case 3:
                        break;
                }//Cierre del switch
                Console.WriteLine("Desea Repetir la Ejecucion del Programa Principal s/n");
                continuar = Console.ReadLine();
            }
            while (continuar == "s" || continuar == "S" || continuar == "Si" || continuar == "SI");
        }
    }
}
