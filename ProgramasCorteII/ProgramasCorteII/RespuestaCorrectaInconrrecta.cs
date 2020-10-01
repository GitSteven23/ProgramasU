using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class RespuestaCorrectaInconrrecta
    {

        public void RespuestaCorrectaInconrrecta1()
        {
            /*Variables*/
            int correctas, incorrectas, blanco, postulantes, 
                puntajec, puntajei,puntajeb;

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("PROGRAMAS CORTE II - C#");
            Console.WriteLine("Respuestas correctas/incorrectas");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite la cantidad de postulantes");
            postulantes = int.Parse(Console.ReadLine());
            postulantes = postulantes + 1;
                        
            for (int i=1; i < postulantes; i++)
            {
                Console.WriteLine("Digite la cantidad de respuestas correctas, para el postulante # "+i);
                correctas = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de respuestas incorrectas");
                incorrectas = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de respuestas en blanco");
                blanco = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                puntajec = correctas * 4;
                puntajei = incorrectas * -1;
                puntajeb = blanco * 0;

                Console.WriteLine("La cantidad de respuestas correctas es : "+correctas );
                Console.WriteLine("La cantidad de respuestas incorrectas es : "+incorrectas);
                Console.WriteLine("la cantidad de respuestas en blanco es : "+blanco);
                Console.WriteLine(" ");

                Console.WriteLine("Puntaje respuestas correctas : " + puntajec);
                Console.WriteLine("Puntaje respuestas incorrectas : " + puntajei);
                Console.WriteLine("Puntaje respuestas en blanco : " + puntajeb);
                Console.WriteLine(" ");


            }


        }
    }
}
