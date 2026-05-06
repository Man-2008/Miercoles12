using System;
using System.Runtime.InteropServices;

namespace _11.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar algoritmo que permita obtener la suma de todos los numeros impares hasta el 99.

            int contador = 1;
            int acumulador = 0;
            
            while (contador <= 99)
            {
                acumulador += contador;
                contador += 2;
            }*/



            /* Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. 
               Al usuario le corresponde ingresar la cantidad de números que va a introducir. 
               El algoritmo debe escribir en pantalla:

                i. La cantidad de números introducidos que son mayores que 0.
                ii. La cantidad de números introducidos menores que 0.
                iii. La cantidad de números iguales a 0.*/

            int cantidadNumeros = 0;
            int numeros = 0;
            int mayoresQueCero = 0;
            int menoresQueCero = 0;
            int igualesACero = 0;
            int n = 0;

            Console.WriteLine("Ingrese la cantidad de números que va a introducir: ");
            cantidadNumeros = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los números: ");

            while ( n < cantidadNumeros)
            {
                numeros = int.Parse(Console.ReadLine());
                if (numeros > 0)
                {
                    mayoresQueCero++;
                }
                else if (numeros < 0)
                {
                    menoresQueCero++;
                }
                else
                {
                    igualesACero++;
                }
                n++;
                

            }

            Console.WriteLine("Cantidad de números mayores que 0: " + mayoresQueCero);
            Console.WriteLine("Cantidad de números menores que 0: " + menoresQueCero);
            Console.WriteLine("Cantidad de números iguales a 0: " + igualesACero);

        }
    }
}
