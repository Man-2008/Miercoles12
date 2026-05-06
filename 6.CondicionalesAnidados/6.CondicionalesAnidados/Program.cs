using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio.
             Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes.
             Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, 
             mostrar mensaje de error.
                9.5-10.0 Excelente 
                8.5-9.4 Muy bien 
                7.5-8.4 Bien*/

            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese la nota 1");
            nota1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            nota2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = Single.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if(promedio >= 9.5 && promedio <= 10.0)
            {
                Console.WriteLine($"Tu promedio es: {promedio}, Excelente trabajo.");
            }
            else
            {
                if(promedio >= 8.5 && promedio <= 9.4)
                {
                    Console.WriteLine($"Tu promedio es: {promedio}, Vas muy bien.");
                }
                else
                {
                    if( promedio >= 7.5 && promedio <= 8.4)
                    {
                        Console.WriteLine($"Tu promedio es: {promedio}, Vas bien, sigue adelante.");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }

        }
    }
}
