using System;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }

            Console.WriteLine("La suma de los cinco primeros numeros enteros es: " + acumulador);*/


            /* Realizar un programa que permita obtener el factorial de un numero entero ingresado por el teclado. */


            /*int numeroIngresado = 0;
            int contador = 0;
            int resultado = 1;

            Console.WriteLine("Ingrese un numero entero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= numeroIngresado; contador++)
            {
                resultado *= contador;
            }

            Console.WriteLine("El factorial del numero ingresado es: " + resultado);*/

            /* Realizar un programa que permita imprimir por pantalla los numeros multiplos de 5, el usuario debe ingresar el limite inferior y el limite superior.

            int limiteInferior = 0;
            int limiteSuperior = 0;

            Console.WriteLine("Ingrese el limite inferior: ");
            limiteInferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el limite superior: ");
            limiteSuperior = int.Parse(Console.ReadLine());

            for (int contador = limiteInferior; contador <= limiteSuperior; contador++)
            {
                if (contador % 5 == 0)
                {
                    Console.WriteLine(contador);
                }
            }*/

            /* En un grupo de 100 alumnos, se desea saber cuantos de los estudiantes son hombres y cuantos son mujeres, ademas se desea saber cuantos son mayores de edad y cuantos son menores de edad. */

            string generoIngresado = "";
            int edadIngresada = 0;
            int hombres = 0;
            int mujeres = 0;
            int menor = 0;
            int mayor = 0;

            

            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine("Ingrese el genero del alumno (H/M): ");
                generoIngresado = Console.ReadLine();
                

                if (generoIngresado == "H")
                {
                    hombres++;
                }
                else if (generoIngresado == "M")
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Genero ingresado no valido.");
                }

                Console.WriteLine("Ingrese la edad del alumno: ");
                edadIngresada = int.Parse(Console.ReadLine());

                if (edadIngresada < 18)
                {
                    menor++;
                }
                else
                {
                    mayor++;
                }

            }

            Console.WriteLine("Cantidad de hombres: " + hombres);
            Console.WriteLine("Cantidad de mujeres: " + mujeres);
            Console.WriteLine("Cantidad de menores de edad: " + menor);
            Console.WriteLine("Cantidad de mayores de edad: " + mayor);

        }
    }
}
