using System;

namespace ProgramasCorteII
{
    public class MatrizCalificaciones
    {
        public void NotasEstudiantes()
        {
            #region Variables

            double[,] notasEstudiantes;
            double promedioEstudiante;
            double sumaValores = 0;
            int numeroMaterias, numeroEstudiantes;

            #endregion

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("PROGRAMAS CORTE II - C#");
            Console.WriteLine("Matriz de calificaciones");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite número de materias");
            numeroMaterias = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite número de estudiantes");
            numeroEstudiantes = int.Parse(Console.ReadLine());

            //Se dan las dimensiones de la matriz
            notasEstudiantes = new double[numeroMaterias, numeroEstudiantes];

            //Llena la matriz con los datos del usuario
            for (int i = 0; i < numeroMaterias; i++)
            {
                for (int j = 0; j < numeroEstudiantes; j++)
                {
                    Console.WriteLine("Digite nota de la materia: {" + i + "," + j + "}");
                    notasEstudiantes[i, j] = double.Parse(Console.ReadLine());
                }
            }

            //Promedio de las materias
            Console.WriteLine("********************************");
            Console.WriteLine("Notas        Promedio Materia");
            for (int i = 0; i < numeroMaterias; i++)
            {
                for (int j = 0; j < numeroEstudiantes; j++)
                {
                    sumaValores = sumaValores + notasEstudiantes[i, j];
                    Console.Write(notasEstudiantes[i, j] + "\t");
                }

                promedioEstudiante = sumaValores / numeroEstudiantes;
                sumaValores = 0;
                Console.WriteLine(promedioEstudiante);
                Console.WriteLine();
            }

            //Promedio de los estudiantes
            Console.WriteLine("********************************");
            Console.WriteLine("Notas     Promedio Estudiante");
            for (int j = 0; j < numeroEstudiantes; j++)
            {
                for (int i = 0; i < numeroMaterias; i++)
                {
                    sumaValores = sumaValores + notasEstudiantes[i, j];
                    Console.Write(notasEstudiantes[j, i] + "\t");
                }

                promedioEstudiante = sumaValores / numeroMaterias;
                sumaValores = 0;
                Console.WriteLine(promedioEstudiante);
                Console.WriteLine();
            }
        }
    }
}