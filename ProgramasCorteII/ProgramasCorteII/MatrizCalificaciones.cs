using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class MatrizCalificaciones
    {
        public void NotasEstudiantes()
        {
            #region Variables

            double[,] notasEstudiantes;
            double promedioEstudiante, sumaValores;
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
                    Console.WriteLine("Digite número de estudiantes");
                }
            }
        }
    }
}
