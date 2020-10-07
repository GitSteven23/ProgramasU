using System;

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
                Console.WriteLine("==============================================");
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
                        FuncionesMatematicas funciones = new FuncionesMatematicas();
                        funciones.FuncionesBasicas();

                        break;

                    case 3:
                        RespuestaCorrectaInconrrecta respuesta = new RespuestaCorrectaInconrrecta();
                        respuesta.RespuestaCorrectaInconrrecta1();
                        break;

                    case 4:
                        Conmebolibertadores conmebolibertadores = new Conmebolibertadores();
                        conmebolibertadores.Conmebolibertadores1();
                        break; 

                    case 5:
                        break;

                    case 6:
                        NumeroCD numero = new NumeroCD();
                        numero.CDNecesarios();
                        break;

                    case 7:
                        Algoritmo matematico = new Algoritmo();
                        matematico.NumerosPositivos();
                        break;

                    case 8:
                        break;

                    case 9:
                        MatrizCalificaciones matriz = new MatrizCalificaciones();
                        matriz.NotasEstudiantes();
                        break;

                    case 10:
                        NominaEmpleados nomina = new NominaEmpleados();
                        nomina.EmpleadoNomina();
                        break;
                }
                Console.WriteLine("Desea volver al menu principal: S/N");
                continuar = Console.ReadLine();
            }
            while (continuar == "s" || continuar == "S");
        }
    }
}
