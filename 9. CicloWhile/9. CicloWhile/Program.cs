using System;
using System.Runtime.ConstrainedExecution;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine("El valor del contador es: " + contador);
                Console.WriteLine("El valor del acumulador es: " + acumulador);
                contador++;
                
            }

            Console.WriteLine("El resultado de la suma es: " + acumulador);



            /*Crear un agoritmo que permita calcular la facoral de Un rimero dado Por el
            usuario. (5! = 1*2*3*4*5)*/

            int numeroIngresado;
            int acumuladorFactorial = 1;

            Console.WriteLine("Ingrese un numero para calcular su factorial: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            int contadorFactorial = 1;
            while (contadorFactorial <= numeroIngresado)
            {
                acumuladorFactorial *= contadorFactorial;
                contadorFactorial++;
            }

            Console.WriteLine("El factorial de " + numeroIngresado + " es: " + acumuladorFactorial);
        }
    }
}
