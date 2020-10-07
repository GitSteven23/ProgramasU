using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class Conmebolibertadores
    {

        public void Conmebolibertadores1()
        {
            /*Variables*/
            int win, lose, draw, total,suma,
                pointsw, pointsl, pointsd;
				
			string Equipo;

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("PROGRAMAS CORTE II - C#");
            Console.WriteLine("Conmebol Libertadores");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite el nombre del equipo");
            Equipo = Console.ReadLine();
            
            do
            {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("La suma de los partids debe ser de 38");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite la cantidad de partidos ganados, para el equipo : "+Equipo);
            win = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de partidos perdidos : ");
            lose = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de partidos empatados :");
            draw = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            pointsw = win * 3;
            pointsl = lose * 0;
            pointsd = draw * 1;
            suma = win + lose + draw;
            total = pointsw + pointsl + pointsd;
            }
            while (suma != 38);

                Console.WriteLine("Cantidad de partidos ganados : "+win );
                Console.WriteLine("Cantidad de partidos perdidos : "+lose);
                Console.WriteLine("Cantidad de partidos empatados: "+draw);
                Console.WriteLine(" ");

                Console.WriteLine("Puntaje de partidos ganados : "+pointsw);
                Console.WriteLine("Puntaje de partidos perdidos : "+pointsl);
                Console.WriteLine("Puntaje de partidos empatados: "+pointsd);
				Console.WriteLine("El puntaje total de "+Equipo+ " es "+total);
                Console.WriteLine(" ");            
        }
    }
}
