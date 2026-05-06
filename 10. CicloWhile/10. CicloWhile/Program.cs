using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese un numero entero positivo");
            numero = int.Parse(Console.ReadLine());


            while (numero >= 0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese un numero entero positivo");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma de los numeros ingresados es: " + acumulador);
        }
    }
}
